<template>
    <div class="home">
        <div class="button-container">
            <button @click="addProduct">Добавить товар</button>
            <table>
                <thead>
                    <tr class="table">
                    <th>Поставщик</th>
                    <th>Склад</th>
                    <th>Название товара</th>
                    <th>Производитель</th>
                    <th>Складская ячейка</th>
                    <th>Цена за единицу</th>
                    <th>Количество на складе</th>
                    </tr>
                </thead>
                <tbody >
                    <tr class="table">
                    <td class="table-cell">
                        <select v-model="newProduct.SupplierID" id="options" class="styled-select" size=2>
                            <option  value="">
                            </option>
                            <option v-for="option in getSortSuppliers" :key="option.iD_Supplier" :value="option.iD_Supplier">
                                {{ option.supplierName }}
                            </option>
                        </select>
                    </td>
                    <td class="table-cell">
                        <select v-model="newProduct.WarehouseID" id="options" class="styled-select" size=2>
                            <option  value="">
                            </option>
                            <option v-for="option in getSortWarehouses" :key="option.iD_Warehouse" :value="option.iD_Warehouse">
                                {{ option.warehouseName }}
                            </option>
                        </select>
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderOne}]"
                        v-model="newProduct.ProductName" placeholder="Введите название" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderTwo}]"
                        v-model="newProduct.Producer" placeholder="Введите производителя" />
                    </td>
                     <td>                
                        <input :class="[{'red-border': titleRBorderThree}]"
                        v-model="newProduct.Cell" placeholder="Введите складскую ячейку" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderFour}]"
                        v-model="newProduct.UnitPrice" placeholder="Введите цену" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderFive}]"
                        v-model="newProduct.QuantityInStock" placeholder="Введите количество" />
                    </td>
                    </tr>
                </tbody>
            </table>
        </div>

        <div class="styled-select-sort-div">
            <select v-model="pag" id="pag" @change="pag_f" class="styled-select-sort pag_count">
                <option value="2"> 2 </option>
                <option value="5"> 5 </option>
                <option value="10"> 10 </option>
            </select>

            Товар:
            <select v-model="sort" id="options" @change="sort_f" class="styled-select-sort">
                <option value="0"> По умолчанию </option>
                <option value="1"> По возрастанию </option>
                <option value="2"> По убыванию </option>
            </select>
            
            Поставщик:
            <select v-model="sortSupplier" id="optionss" @change="sortSupplier_f" class="styled-select-sort">
                <option value="0"> По умолчанию </option>
                <option value="1"> По возрастанию </option>
                <option value="2"> По убыванию </option>
            </select>

            Склад:
            <select v-model="sortWarehouse" id="optionsss" @change="sortWarehouse_f" class="styled-select-sort">
                <option value="0"> По умолчанию </option>
                <option value="1"> По возрастанию </option>
                <option value="2"> По убыванию </option>
            </select>

            Производитель:
            <select v-model="sortProducer" id="optionssss" @change="sortProducer_f" class="styled-select-sort">
                <option value="0"> По умолчанию </option>
                <option value="1"> По возрастанию </option>
                <option value="2"> По убыванию </option>
            </select>
            
        </div>

        <ProductsTable />
        
        <div class="pagination-container">
            <div class="pagination" @click="moveBack">Назад</div>
            {{ getPage }} из {{ getTotalPages }}
            <div class="pagination right" @click="moveForward">Вперед</div>
        </div>

        <ProductsModal v-if="showProductsModal" class="modal"/>
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';
import ProductsTable from '@/components/ProductsTable.vue'
import ProductsModal from '@/components/ProductsModal.vue';


export default {
    name: 'ProductsView',
    components: {
        ProductsTable,
        ProductsModal
    },
    data() {
        return {
            newProduct: {SupplierID: "", WarehouseID: "", ProductName: "", Producer: "", Cell: "", UnitPrice: 0, QuantityInStock: 0},
            page: 1,
            sort: 0,
            sortProducer: 0,
            sortSupplier: 0,
            sortWarehouse: 0,
            pag: 10,
            }
    },
    watch: {
    },
    mounted()
    {
        this.page = 1;
        this.setPage(this.page);
        this.fetchSuppliers();
        this.fetchWarehouses();
        this.pag = this.getitemsPerPage
    },
    methods: {
        ...mapActions('products', ['newProducts']),
        ...mapActions('suppliers', ['fetchSuppliers']),
        ...mapActions('warehouses', ['fetchWarehouses']),
        ...mapMutations('products', ['setPage','changeSort','changeSortProducer','changeSortSupplier','changeSortWarehouse','changePagination']), // Map mutations to methods
        addProduct()
        {
            if(this.newProduct.SupplierID != '' && 
                this.newProduct.WarehouseID != '' && 
                this.newProduct.ProductName != '' && 
                this.newProduct.Producer != '' && 
                this.newProduct.Cell != '' && 
                this.newProduct.UnitPrice != 0 && 
                this.newProduct.QuantityInStock != 0)
            {
                this.newProducts(this.newProduct);
                this.newProduct.SupplierID = ''; 
                this.newProduct.WarehouseID = '';
                this.newProduct.ProductName = '';
                this.newProduct.Producer = '';
                this.newProduct.Cell = '';
                this.newProduct.UnitPrice = 0;
                this.newProduct.QuantityInStock = 0;
            } else {
                console.log("Не все данные введены");
            }
        },
        moveBack()
        {
            this.page--;
            if(this.page < 1) this.page = 1;
            this.setPage(this.page);
            // this.$router.push({ name: 'supplier', params: { id: this.page } });
        },
        moveForward()
        {
            this.page++;
            if(this.page > this.getTotalPages) this.page = this.getTotalPages;
            this.setPage(this.page);
            // this.$router.push({ name: 'supplier', params: { id: this.page } });
        },
        sort_f()
        {
            this.sortProducer = 0;
            this.sortSupplier = 0;
            this.sortWarehouse = 0;
            this.changeSort(this.sort);
        },
        sortSupplier_f()
        {
            this.sort = 0;
            this.sortProducer = 0;
            this.sortWarehouse = 0;
            this.changeSortSupplier(this.sortSupplier);
        },
        sortWarehouse_f()
        {
            this.sort = 0;
            this.sortProducer = 0;
            this.sortSupplier = 0;
            this.changeSortWarehouse(this.sortWarehouse);
        },
        sortProducer_f()
        {
            this.sort = 0;
            this.sortSupplier = 0;
            this.sortWarehouse = 0;
            this.changeSortProducer(this.sortProducer);
        },
        pag_f()
        {
            this.changePagination(this.pag);
        }
    },
    computed: {
        ...mapGetters('products', ['getTotalPages', 'getPage','getModalState','getitemsPerPage']),
        ...mapGetters('suppliers', ['getSortSuppliers']),
        ...mapGetters('warehouses', ['getSortWarehouses']),
        titleRBorderOne() {
            return this.newProduct.ProductName === ''
        },
        titleRBorderTwo() {
            return this.newProduct.Producer === ''
        },
        titleRBorderThree() {
            return this.newProduct.Cell === ''
        },
        titleRBorderFour() {
            return this.newProduct.UnitPrice === 0
        },
        titleRBorderFive() {
            return this.newProduct.QuantityInStock === 0
        },
        showProductsModal() {
            return this.getModalState;
        }
    }
    
}
</script>

<style lang="scss" scoped>
.button-container {
    display: flex; /* Use flexbox for alignment */
    justify-content: flex-start; /* Align items to the left */
    margin-bottom: 40px; /* Space between button and table */
}
button {
    padding: 5px 10px; /* Отступы внутри кнопки */
    background-color: #4CAF50; /* Зеленый цвет фона кнопки */
    color: white; /* Цвет текста кнопки */
    border: none; /* Убираем границу */
    border-radius: 4px; /* Закругленные углы */
    cursor: pointer; /* Указатель при наведении */
    transition: background-color 0.3s; /* Плавный переход цвета фона */
    left: 10%;
}   

button:hover {
    background-color: #45a049; /* Темно-зеленый цвет фона кнопки при наведении */
}

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

input {
  width: 90%; /* Make input fields take full width of the cell */
  height: 100%;
  padding: 4px; /* Padding inside input fields */
  border: 1px solid #ccc; /* Border for input fields */
  border-radius: 8px; /* Rounded corners */
}

.red-border {
    border-color: rgb(165, 18, 18);
    border-width: 2px;
}

.pagination-container
{
    display: flex; /* Use flexbox for alignment */
    justify-content: center; /* Align items to the left */
    margin-top: 40px; 
}
.pagination
{
    margin-right: 20px;
    cursor: pointer;
    transition: background-color 0.3s;
}
.pagination:hover {
    color: green; /* Change text color for better contrast */
}
.pagination:active {
    color: red; /* Change text color for better contrast */
}
.right{
    margin-left: 20px;
}


.styled-select {
    width: 100%; /* Full width */
    padding: 10px; /* Padding for better spacing */
    border: 1px solid #ccc; /* Light gray border */
    border-radius: 4px; /* Rounded corners */
    background-color: #fff; /* White background */
    font-size: 16px; /* Font size */
    color: #333; /* Text color */
    cursor: pointer; /* Pointer cursor on hover */
    transition: border-color 0.3s; /* Smooth transition for border color */
}

.styled-select:focus {
    border-color: #007bff; /* Change border color on focus */
    outline: none; /* Remove default outline */
}

.styled-select option {
    padding: 10px; /* Padding for options */
}

.styled-select option:checked {
    background-color: #beeeb1; /* Padding for options */
}

.table-cell {
    max-width: 250px; /* Set your desired max width */
    overflow: hidden; /* Hide overflow content */
    text-overflow: ellipsis; /* Add ellipsis for overflowed text */
    // white-space: wrap; /* Prevent text from wrapping */
}


.styled-select-sort-div{
    display: flex; /* Use flexbox for alignment */
    justify-content: flex-start; /* Align items to the left */
    margin-bottom: 10px;
    align-items: center;
}

.styled-select-sort {
    margin-right: 20px;
    margin-left: 10px;
    width: 10%; /* Full width */
    padding: 10px; /* Padding for better spacing */
    border: 2px solid #cccccc; /* Light gray border */
    border-radius: 4px; /* Rounded corners */
    background-color: #fff; /* White background */
    font-size: 16px; /* Font size */
    color: #333; /* Text color */
    cursor: pointer; /* Pointer cursor on hover */
    transition: border-color 0.3s; /* Smooth transition for border color */
}

.styled-select-sort:focus {
    border-color: #007bff; /* Change border color on focus */
    outline: none; /* Remove default outline */
}

.styled-select-sort option {
    padding: 10px; /* Padding for options */
}

.pag_count {
    width: 5%;
}
</style>