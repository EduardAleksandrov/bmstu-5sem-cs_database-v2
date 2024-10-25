<template>
    <div class="home">
        <div class="button-container">
            <button @click="addSupplier">Добавить поставщика</button>
            <table>
                <thead>
                    <tr class="table">
                    <th>Название поставщика</th>
                    <th>Контактное имя</th>
                    <th>email</th>
                    <th>phone</th>
                    </tr>
                </thead>
                <tbody >
                    <tr class="table">
                    <td>
                        <input :class="[{'red-border': titleRBorderOne}]"
                        v-model="newSupllier.SupplierName" placeholder="Введите название поставщика" />
                    </td>
                    <td>                
                        <input  :class="[{'red-border': titleRBorderTwo}]"
                        v-model="newSupllier.ContactName" placeholder="Введите контактное имя" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderThree}]"
                        v-model="newSupllier.Email" placeholder="Введите email" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderFour}]"
                        v-model="newSupllier.Phone" placeholder="Введите телефон" />
                    </td>
                    </tr>
                </tbody>
            </table>
        </div>

        <SuppliersTable />
        
        <div class="pagination-container">
            <div class="pagination" @click="moveBack">Назад</div>
            {{ getPage }}
            <div class="pagination right" @click="moveForward">Вперед</div>
        </div>

        <SuppliersModal v-if="showSuppliersModal" class="modal"/>
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';
import SuppliersTable from '@/components/SuppliersTable.vue'
import SuppliersModal from '@/components/SuppliersModal.vue';


export default {
    name: 'SuppliersView',
    components: {
        SuppliersTable,
        SuppliersModal
    },
    data() {
        return {
            newSupllier: {SupplierName: "", ContactName: "", Email: "", Phone: ""},
            page: 1,
            }
    },
    methods: {
        ...mapActions('suppliers', ['newSuppliers']),
        ...mapMutations('suppliers', ['setPage']), // Map mutations to methods
        addSupplier()
        {
            if(this.newSupllier.SupplierName != '' && this.newSupllier.ContactName != '' && this.newSupllier.Email != '' && this.newSupllier.Phone != '')
            {
                this.newSuppliers(this.newSupllier);
                this.newSupllier.SupplierName = '';
                this.newSupllier.ContactName = '';
                this.newSupllier.Email = '';
                this.newSupllier.Phone = ''
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
        ...mapGetters('suppliers', ['getTotalPages', 'getPage','getModalState']),
        titleRBorderOne() {
            return this.newSupllier.SupplierName === ''
        },
        titleRBorderTwo() {
            return this.newSupllier.ContactName === ''
        },
        titleRBorderThree() {
            return this.newSupllier.Email === ''
        },
        titleRBorderFour() {
            return this.newSupllier.Phone === ''
        },
        showSuppliersModal() {
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