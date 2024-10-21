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
                        v-model="newSupllier.Email" placeholder="Введите контактное имя" />
                    </td>
                    <td>                
                        <input :class="[{'red-border': titleRBorderFour}]"
                        v-model="newSupllier.Phone" placeholder="Введите контактное имя" />
                    </td>
                    </tr>
                </tbody>
            </table>
        </div>

        <SuppliersTable />

    </div>
</template>

<script>
import { mapActions } from 'vuex';
import SuppliersTable from '@/components/SuppliersTable.vue'

export default {
    name: 'HomeView',
    components: {
        SuppliersTable
    },
    data() {
        return {
            newSupllier: {SupplierName: "", ContactName: "", Email: "", Phone: ""}
            }
        }
    ,
    methods: {
        ...mapActions('suppliers', ['newSuppliers']),
        addSupplier()
        {
            if(this.newSupllier.SupplierName != '' && this.newSupllier.ContactName != '' && this.newSupllier.Email != '' && this.newSupllier.Phone != '')
            {
                this.newSuppliers(this.newSupllier);
            } else {
                console.log("Не все данные введены");            }
        }
    },
    computed: {
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

</style>