<template>
    <div class="home">

        <div class="inputs__wrapper">
            <p>Поиск: </p>
            <input class="inputs__search"
            v-model="searchEmail" placeholder="Введите email" />
        </div>
        <OrderlistsTable />
        
        <div class="pagination-container">
            <div class="pagination" @click="moveBack">Назад</div>
            {{ getPage }} из {{ getTotalPages }}
            <div class="pagination right" @click="moveForward">Вперед</div>
        </div>

        <OrderlistsModal v-if="showOrderlistsModal" class="modal"/>
        <OrderlistsdetailsModal v-if="showOrderlistsdetailsModal" class="modal"/>
        
    </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from 'vuex';
import OrderlistsTable from '@/components/OrderlistsTable.vue'
import OrderlistsModal from '@/components/OrderlistsModal.vue';
import OrderlistsdetailsModal from '@/components/OrderlistsdetailsModal.vue';


export default {
    name: 'OrderlistsView',
    components: {
        OrderlistsTable,
        OrderlistsModal,
        OrderlistsdetailsModal
    },
    data() {
        return {
            page: 1,
            searchEmail: ''
            }
    },
    watch: {
        searchEmail()
        {
            this.searchEmailMut(this.searchEmail);
            this.searchAllCustomers(this.allCustomers);
        }
    },
    mounted()
    {
        this.fetchCustomers();
        this.fetchProducts();
    },
    methods: {
        ...mapActions('customers', ['fetchCustomers']),
        ...mapActions('products', ['fetchProducts']),
        ...mapMutations('orderlists', ['setPage','searchEmailMut', 'searchAllCustomers']), // Map mutations to methods
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
        ...mapGetters('orderlists', ['getTotalPages', 'getPage','getModalState', 'getModalOrderDetailsState']),
        ...mapGetters('customers', ['allCustomers']),

        showOrderlistsModal() {
            return this.getModalState;
        },
        showOrderlistsdetailsModal()
        {
            return this.getModalOrderDetailsState;
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

.inputs__wrapper {
    display: flex; /* Use flexbox for alignment */
    justify-content: flex-start; /* Align items to the left */
    margin-bottom: 10px;
    align-items: center;
}
.inputs__search {
    width:20%;
    padding: 10px; /* Padding for better spacing */
    border: 2px solid #cccccc; /* Light gray border */
    border-radius: 4px; /* Rounded corners */
    background-color: #fff; /* White background */
    font-size: 16px;
    margin-left:15px;
}
.inputs__search:focus{
    border-color: #19a53c; /* Light gray border */
    outline: none;
}
</style>