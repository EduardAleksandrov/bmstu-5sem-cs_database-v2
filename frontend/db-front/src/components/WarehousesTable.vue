<template>
    <div class="listOfSyppliers__wrapper">
      <!-- <div class="listOfSyppliers__items" v-for="el in allSuppliers" :key="el.Id">
        {{ el.contactName }}
      </div> -->
      <table>
      <thead>
        <tr class="table">
          <th>Название склада</th>
          <th>Местоположение</th>
          <th>Менеджер</th>
          <th>Емкость</th>
          <th>Action</th>
          <th>Action</th>
        </tr>
      </thead>
      <tbody >
        <tr class="table" v-for="el in getWarehousesByPage" :key="el.id">
          <td>{{ el.warehouseName }}</td>
          <td>{{ el.location }}</td>
          <td>{{ el.managerName }}</td>
          <td>{{ el.capacity }}</td>
          <td>
            <button @click="changeWare(el)">Изменить</button>
          </td>
          <td>
            <button @click="deleteWare(el)">Удалить</button>
          </td>
        </tr>
      </tbody>
    </table>
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';

export default {
    name: 'WarehousesTable',
    methods: {
      ...mapActions('warehouses', ['fetchWarehouses', 'deleteWarehouse']),
      ...mapMutations('warehouses', ['showModal','setCurrentEl']),
      changeWare(el)
      {
        // console.log(el);
        this.setCurrentEl(el);
        this.showModal(true);
      },
      deleteWare(el)
      {
        this.deleteWarehouse(el);
      }
    },
    computed: {
      ...mapGetters('warehouses', ['allWarehouses', 'getWarehousesByPage']),

    },
    mounted() {
      this.$store.dispatch('warehouses/fetchWarehouses');
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
