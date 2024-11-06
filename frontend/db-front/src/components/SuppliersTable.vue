<template>
    <div class="listOfSyppliers__wrapper">
      <!-- <div class="listOfSyppliers__items" v-for="el in allSuppliers" :key="el.Id">
        {{ el.contactName }}
      </div> -->
      <table>
      <thead>
        <tr class="table">
          <th>Название поставщика</th>
          <th>Контактное имя</th>
          <th>Email</th>
          <th>Phone</th>
          <th>Action</th>
          <th>Action</th>
        </tr>
      </thead>
      <tbody >
        <tr class="table" v-for="el in getSuppliersByPage" :key="el.id">
          <td class="table-cell">{{ el.supplierName }}</td>
          <td>{{ el.contactName }}</td>
          <td>{{ el.email }}</td>
          <td>{{ el.phone }}</td>
          <td>
            <button @click="changeSupp(el)">Изменить</button>
          </td>
          <td>
            <button @click="deleteSupp(el)">Удалить</button>
          </td>
        </tr>
      </tbody>
    </table>
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';

export default {
    name: 'Suppliers',
    methods: {
      ...mapActions('suppliers', ['fetchSuppliers', 'deleteSupplier']),
      ...mapMutations('suppliers', ['showModal','setCurrentEl']),
      changeSupp(el)
      {
        // console.log(el);
        this.setCurrentEl(el);
        this.showModal(true);
      },
      deleteSupp(el)
      {
        this.deleteSupplier(el);
      }
    },
    computed: {
      ...mapGetters('suppliers', ['allSuppliers', 'getSuppliersByPage']),

    },
    mounted() {
      this.$store.dispatch('suppliers/fetchSuppliers');
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

  .table-cell {
    max-width: 250px; /* Set your desired max width */
    overflow-wrap: break-word;
    word-break: break-word;
  }
</style>
