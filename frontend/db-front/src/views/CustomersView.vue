<template>
    <div class="home">
        <div class="button-container">
            <button @click="addCustomer">Добавить покупателя</button>
            <table>
                <thead>
                    <tr class="table">
                    <th>Имя</th>
                    <th>Phone</th>
                    <th>Email</th>
                    <th>Адрес</th>
                    </tr>
                </thead>
                <tbody >
                    <tr class="table">
                    <td>
                        <input :class="[{'red-border': titleRBorderOne}]"
                        v-model="newCustomer.CustomerName" placeholder="Введите имя" />
                    </td>
                    <td>                
                        <input  :class="[{'red-border': titleRBorderTwo}]"
                        v-model="newCustomer.Phone" placeholder="Введите телефон" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderThree}]"
                        v-model="newCustomer.Email" placeholder="Введите email" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderFour}]"
                        v-model="newCustomer.Address" placeholder="Введите адрес" />
                    </td>
                    </tr>
                </tbody>
            </table>
        </div>

        <CustomersTable />
        
        <div class="pagination-container">
            <div class="pagination" @click="moveBack">Назад</div>
            {{ getPage }}
            <div class="pagination right" @click="moveForward">Вперед</div>
        </div>

        <CustomersModal v-if="showCustomersModal" class="modal"/>
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';
import CustomersTable from '@/components/CustomersTable.vue'
import CustomersModal from '@/components/CustomersModal.vue';


export default {
    name: 'CustomersView',
    components: {
        CustomersTable,
        CustomersModal
    },
    data() {
        return {
            newCustomer: {CustomerName: "", Phone: "", Email: "", Address: ""},
            page: 1,
            }
    },
    methods: {
        ...mapActions('customers', ['newCustomers']),
        ...mapMutations('customers', ['setPage']), // Map mutations to methods
        addCustomer()
        {
            if(this.newCustomer.CustomerName != '' && this.newCustomer.Phone != '' && this.newCustomer.Email != '' && this.newCustomer.Address != '')
            {
                this.newCustomers(this.newCustomer);
                this.newCustomer.CustomerName = '';
                this.newCustomer.Phone = '';
                this.newCustomer.Email = '';
                this.newCustomer.Address = ''
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
        ...mapGetters('customers', ['getTotalPages', 'getPage','getModalState']),
        titleRBorderOne() {
            return this.newCustomer.CustomerName === ''
        },
        titleRBorderTwo() {
            return this.newCustomer.Phone === ''
        },
        titleRBorderThree() {
            return this.newCustomer.Email === ''
        },
        titleRBorderFour() {
            return this.newCustomer.Address === ''
        },
        showCustomersModal() {
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