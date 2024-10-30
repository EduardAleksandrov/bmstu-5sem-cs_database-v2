<template>
    <div class="listOfSyppliers__wrapper">
      <!-- <div class="listOfSyppliers__items" v-for="el in allSuppliers" :key="el.Id">
        {{ el.contactName }}
      </div> -->
      <table>
      <thead>
        <tr class="table">
          <th>Покупатель Имя</th>
          <th>Покупатель email</th>
          <th>Покупатель phone</th>
          <th>Сумма</th>
          <th>Дата заказа</th>
          <th>Статус</th>
          <th>Action</th>
          <th>Action</th>
        </tr>
      </thead>
      <tbody >
        <tr class="table" v-for="el in getOrderlistsByPage" :key="el.id">
          <td>{{ getCustomerNameById(el.customerID) }}</td>
          <td>{{ getCustomerEmailById(el.customerID) }}</td>
          <td>{{ getCustomerPhoneById(el.customerID) }}</td>
          <td>{{ el.totalAmount }}</td>
          <td>{{ getDate(el.orderDate) }}</td>
          <td>{{ el.status }}</td>
          <td>
            <button @click="changeOrd(el)">Изменить</button>
          </td>
          <td>
            <button @click="showOrd(el)">Посмотреть товары</button>
          </td>
        </tr>
      </tbody>
    </table>
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';

export default {
    name: 'OrderlistsTable',
    methods: {
      ...mapActions('orderlists', ['fetchOrderlists',]),
      ...mapMutations('orderlists', ['showModal','setCurrentEl','showOrderDetailsModal']),
      changeOrd(el)
      {
        // console.log(el);
        this.setCurrentEl(el);
        this.showModal(true);
      },
      showOrd(el)
      {
        this.setCurrentEl(el);
        this.showOrderDetailsModal(true);
      },
      getCustomerNameById(id)
      {
        // console.log(id);
        let customer = this.allCustomers.find(s => s.iD_Customer === id);
        if (customer) {
            return customer.customerName; // Return the supplier name if found
        } else {
            console.log("Customer not found");
            return ""; // Return an empty string or a default value if not found
        }
      },
      getCustomerEmailById(id)
      {
        // console.log(id);
        let customer = this.allCustomers.find(s => s.iD_Customer === id);
        if (customer) {
            return customer.email; // Return the supplier name if found
        } else {
            console.log("Customer not found");
            return ""; // Return an empty string or a default value if not found
        }
      },
      getCustomerPhoneById(id)
      {
        // console.log(id);
        let customer = this.allCustomers.find(s => s.iD_Customer === id);
        if (customer) {
            return customer.phone; // Return the supplier name if found
        } else {
            console.log("Customer not found");
            return ""; // Return an empty string or a default value if not found
        }
      },
      getDate(isoString)
      { 
        const date = new Date(isoString);

        // Extract the date and time
        const dateString = date.toISOString().split('T')[0]; // Gets the date part (YYYY-MM-DD)
        const timeString = date.toISOString().split('T')[1].split('.')[0]; // Gets the time part (HH:mm:ss)

        // Combine date and time
        const dateTimeString = `${dateString} ${timeString}`;
        return dateTimeString;
      }
    },
    computed: {
      ...mapGetters('orderlists', ['allOrderlists', 'getOrderlistsByPage']),
      ...mapGetters('customers', ['allCustomers']),

    },
    mounted() {
      this.$store.dispatch('orderlists/fetchOrderlists');
    },
}
</script>

<style lang="scss" scoped>

  table {
  width: 100%; /* Занимает всю ширину окна */
  border-collapse: collapse; /* Убирает двойные границы между ячейками */
  }

  th, td {
    border: 1px solid #ddd; /* Граница ячеек */
    padding: 8px; /* Отступы внутри ячеек */
    text-align: left; /* Выравнивание текста по левому краю */
  }

  th {
    background-color: #f2f2f2; /* Цвет фона заголовков */
  }

  tr:hover {
    background-color: #f5f5f5; /* Цвет фона строки при наведении */
  }

  button {
    padding: 5px 10px; /* Отступы внутри кнопки */
    background-color: #4CAF50; /* Цвет фона кнопки */
    color: white; /* Цвет текста кнопки */
    border: none; /* Убираем границу */
    border-radius: 4px; /* Закругленные углы */
    cursor: pointer; /* Указатель при наведении */
  }

  button:hover {
    background-color: #45a049; /* Цвет фона кнопки при наведении */
  }

  
</style>
