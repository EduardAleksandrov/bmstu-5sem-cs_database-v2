<template>
    <div class="listOfSyppliers__wrapper">
      <!-- <div class="listOfSyppliers__items" v-for="el in allSuppliers" :key="el.Id">
        {{ el.contactName }}
      </div> -->
      <table>
      <thead>
        <tr class="table">
          <th>Название товара</th>
          <th>Поставщик</th>
          <th>Склад</th>
          <th>Производитель</th>
          <th>Складская ячейка</th>
          <th>Цена за единицу</th>
          <th>Количество на складе</th>
          <th>Action</th>
          <th>Action</th>
        </tr>
      </thead>
      <tbody >
        <tr class="table" v-for="el in getProductsByPage" :key="el.iD_Product">
          <td class="table-cell">{{ el.productName }}</td>
          <td>{{ getSupplierById(el.supplierID) }}</td>
          <td>{{ getWarehouseById(el.warehouseID) }}</td>
          <td>{{ el.producer }}</td>
          <td>{{ el.cell }}</td>
          <td>{{ el.unitPrice }}</td>
          <td>{{ el.quantityInStock }}</td>
          <td>
            <button @click="changeProd(el)">Изменить</button>
          </td>
          <td>
            <button @click="deleteProd(el)">Удалить</button>
          </td>
        </tr>
      </tbody>
    </table>
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';

export default {
    name: 'Products',
    methods: {
      ...mapActions('products', ['fetchProducts', 'deleteProduct']),
      ...mapMutations('products', ['showModal','setCurrentEl']),
      changeProd(el)
      {
        // console.log(el);
        this.setCurrentEl(el);
        this.showModal(true);
      },
      deleteProd(el)
      {
        this.deleteProduct(el);
      },
      getSupplierById(id)
      {
        // console.log(id);
        let supplier = this.allSuppliers.find(s => s.iD_Supplier === id);
        if (supplier) {
            // console.log(supplier.supplierName);
            return supplier.supplierName; // Return the supplier name if found
        } else {
            console.log("Supplier not found");
            return ""; // Return an empty string or a default value if not found
        }
        // console.log(supplier.supplierName);
        // return supplier.supplierName? supplier.supplierName: "";
      },
      getWarehouseById(id)
      {
        let warehouse = this.allWarehouses.find(s => s.iD_Warehouse === id);
        if (warehouse) {
            return warehouse.warehouseName; 
        } else {
            console.log("Warehose not found");
            return ""; 
        }
      },
    },
    computed: {
      ...mapGetters('products', ['allProducts', 'getProductsByPage']),
      ...mapGetters('suppliers', ['allSuppliers']),
      ...mapGetters('warehouses', ['allWarehouses']),
    },
    mounted() {
      this.$store.dispatch('products/fetchProducts');
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
    overflow: hidden; /* Hide overflow content */
    text-overflow: ellipsis; /* Add ellipsis for overflowed text */
    white-space: nowrap; /* Prevent text from wrapping */
}
  
</style>
