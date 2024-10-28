<template>
    <div class="home">
        <div class="button-container">
            <button @click="addWarehouse">Добавить склад</button>
            <table>
                <thead>
                    <tr class="table">
                    <th>Название склада</th>
                    <th>Местоположение</th>
                    <th>Менеджер</th>
                    <th>Емкость</th>
                    </tr>
                </thead>
                <tbody >
                    <tr class="table">
                    <td>
                        <input :class="[{'red-border': titleRBorderOne}]"
                        v-model="newWarehouse.WarehouseName" placeholder="Введите название склада" />
                    </td>
                    <td>                
                        <input  :class="[{'red-border': titleRBorderTwo}]"
                        v-model="newWarehouse.Location" placeholder="Введите местоположение" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderThree}]"
                        v-model="newWarehouse.ManagerName" placeholder="Введите менеджера" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderFour}]"
                        v-model="newWarehouse.Capacity" placeholder="Введите емкость" />
                    </td>
                    </tr>
                </tbody>
            </table>
        </div>

        <WarehousesTable />
        
        <div class="pagination-container">
            <div class="pagination" @click="moveBack">Назад</div>
            {{ getPage }} из {{ getTotalPages }}
            <div class="pagination right" @click="moveForward">Вперед</div>
        </div>

        <WarehousesModal v-if="showWarehousesModal" class="modal"/>
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';
import WarehousesTable from '@/components/WarehousesTable.vue'
import WarehousesModal from '@/components/WarehousesModal.vue';


export default {
    name: 'WarehousesView',
    components: {
        WarehousesTable,
        WarehousesModal
    },
    data() {
        return {
            newWarehouse: {WarehouseName: "", Location: "", ManagerName: "", Capacity: 0},
            page: 1,
            }
    },
    methods: {
        ...mapActions('warehouses', ['newWarehouses']),
        ...mapMutations('warehouses', ['setPage']), // Map mutations to methods
        addWarehouse()
        {
            if(this.newWarehouse.WarehouseName != '' && this.newWarehouse.Location != '' && this.newWarehouse.ManagerName != '' && this.newWarehouse.Capacity != 0 && this.newWarehouse.Capacity != '')
            {
                this.newWarehouses(this.newWarehouse);
                this.newWarehouse.WarehouseName = '';
                this.newWarehouse.Location = '';
                this.newWarehouse.ManagerName = '';
                this.newWarehouse.Capacity = 0
            } else {
                console.log("Не все данные введены");
            }
        },
        moveBack()
        {
            this.page--;
            if(this.page < 1) this.page = 1;
            this.setPage(this.page);
        },
        moveForward()
        {
            this.page++;
            if(this.page > this.getTotalPages) this.page = this.getTotalPages;
            this.setPage(this.page);
        }
    },
    computed: {
        ...mapGetters('warehouses', ['getTotalPages', 'getPage','getModalState']),
        titleRBorderOne() {
            return this.newWarehouse.WarehouseName === ''
        },
        titleRBorderTwo() {
            return this.newWarehouse.Location === ''
        },
        titleRBorderThree() {
            return this.newWarehouse.ManagerName === ''
        },
        titleRBorderFour() {
            return this.newWarehouse.Capacity === 0 || this.newWarehouse.Capacity === ''
        },
        showWarehousesModal() {
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
</style>