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
          <th>email</th>
          <th>phone</th>
          <th>Action</th>
          <th>Action</th>
        </tr>
      </thead>
      <tbody >
        <tr class="table" v-for="el in allSuppliers" :key="el.id">
          <td>{{ el.supplierName }}</td>
          <td>{{ el.contactName }}</td>
          <td>{{ el.email}}</td>
          <td>{{ el.phone}}</td>
          <td>
            <button @click="changeSupplier(el)">Изменить</button>
          </td>
          <td>
            <button @click="deleteSupplier(el)">Удалить</button>
          </td>
        </tr>
      </tbody>
    </table>
    </div>
</template>

<script>
import { mapGetters, mapActions } from 'vuex';

export default {
    name: 'Suppliers',
    methods: {
      ...mapActions('suppliers', ['fetchSuppliers']),
      changeSupplier(el)
      {
        console.log(el.iD_Supplier);
      },
      deleteSupplier(el)
      {
        console.log(el.iD_Supplier);
      }
    },
    computed: {
      ...mapGetters('suppliers', ['allSuppliers']),

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

  
</style>
