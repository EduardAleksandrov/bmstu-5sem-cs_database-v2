<template>
    <div class="listOfSyppliers__wrapper">
      <table>
      <thead>
        <tr class="table">
          <th>Имя</th>
          <th>Phone</th>
          <th>Email</th>
          <th>Адрес</th>
          <th>Action</th>
          <th>Action</th>
        </tr>
      </thead>
      <tbody >
        <tr class="table" v-for="el in getCustomersByPage" :key="el.id">
          <td>{{ el.customerName }}</td>
          <td>{{ el.phone }}</td>
          <td>{{ el.email }}</td>
          <td>{{ el.address }}</td>
          <td>
            <button @click="changeCus(el)">Изменить</button>
          </td>
          <td>
            <button @click="deleteCus(el)">Удалить</button>
          </td>
        </tr>
      </tbody>
    </table>
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';

export default {
    name: 'Customers',
    methods: {
      ...mapActions('customers', ['fetchCustomers', 'deleteCustomer']),
      ...mapMutations('customers', ['showModal','setCurrentEl']),
      changeCus(el)
      {
        // console.log(el);
        this.setCurrentEl(el);
        this.showModal(true);
      },
      deleteCus(el)
      {
        this.deleteCustomer(el);
      }
    },
    computed: {
      ...mapGetters('customers', ['allCustomers', 'getCustomersByPage']),

    },
    mounted() {
      this.$store.dispatch('customers/fetchCustomers');
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
