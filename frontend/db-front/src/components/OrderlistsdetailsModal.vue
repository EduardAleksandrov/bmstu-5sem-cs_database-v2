<template>
    <div class="form">
        <div class="form__wrapper">
            <div class="form__text-wrapper">
                <h1>
                    Форма
                </h1>
                <br>
                <table>
                    <thead>
                        <tr class="table">
                        <th>Товар</th>
                        <th>Количество</th>
                        <th>Цена за единицу</th>
                        </tr>
                    </thead>
                    <tbody >
                        <tr class="table" v-for="el in getcurrentElementForModal.orderDetails" :key="el.id">
                        <td class="table-cell">{{ getProductNameById(el.productId) }}</td>
                        <td>{{ el.quantity }}</td>
                        <td>{{ el.unitPrice }}</td>
                        </tr>
                    </tbody>
                    </table>
                
                <div style="margin-bottom: 20px;">
                    <button class="form__text-clear" @click="closeModal">Закрыть форму</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import { mapGetters, mapState, mapMutations, mapActions } from 'vuex';
export default {
    name: 'OrderdetailsModal',
    data() {
        return {
        };
    },
    mounted() {
    },
    watch: {
    },  
    methods: {
        ...mapMutations('orderlists', ['showOrderDetailsModal']),
        closeModal() {
            this.showOrderDetailsModal(false);
        },
        saveChanges() 
        {
            this.showOrderDetailsModal(false);
        },
        getProductNameById(id)
        {
            // console.log(id);
            let product = this.allProducts.find(s => s.iD_Product === id);
            if (product) {
                return product.productName; // Return the supplier name if found
            } else {
                console.log("Product not found");
                return ""; // Return an empty string or a default value if not found
            }
        },
    },
    computed: {
        ...mapGetters('orderlists', ['getcurrentElementForModal']),
        ...mapGetters('products', ['allProducts']),
        orderlistsYBorder() {
            return this.getcurrentElementForModal.status === this.status;
        },
    }
}
</script>

<style lang="scss" scoped>
.form {
    &__wrapper {
        position: absolute;
        top:50%;
        left: 50%;
        transform: translate(-50%, -50%);
        z-index: 2;
        background-color:#fff;
        padding: 40px 50px;
        z-index: 12;

        min-width: 1000px;
        min-height: 400px;
        //border: 2px solid rgb(136, 136, 136);
        border-radius: 10px;
        box-shadow: 0 0 10px rgba(0,0,0,0.5);
        display: flex;
        flex-direction: column;
        //justify-content: center;
        align-items: center;
        
    }
    &__text-wrapper {
        width: 100%;
        display:flex;
        flex-direction: column;
    }

    &__text {
        // width: 100%;
        margin-bottom: 20px;
        border: 3px solid rgb(185, 185, 185);
        border-radius: 4px;
        border-color: green;
        padding: 10px 10px;
    }

    &__text-title {
        margin-bottom: 4px;
    }

    &__text-clear {
        border: 1px solid rgb(255, 251, 0);
        border-radius: 4px;
        color: rgb(0, 0, 0);
        padding: 10px 15px;
        background-color: rgb(247, 230, 139);
        cursor: pointer;
        &:hover {
            background-color: rgb(163, 162, 162);
        }
        &:active {
            color:aqua;
        }
    }

    &__text-submit {
        margin-right: 10px;
        border: none;
        border-radius: 4px;
        color: rgb(255, 255, 255);
        padding: 10px 15px;
        background-color: rgb(72, 100, 253);
        cursor: pointer;
        &:active {
            color:aqua;
        }
    }

    &__attention {
        font-weight: 700;
        color: rgb(109, 11, 11);
    }
}

.yellow-border {
    border-color: rgb(172, 172, 9);
}
.red-border {
    border-color: rgb(109, 11, 11);
}



.styled-select {
    width: 100%; /* Full width */
    padding: 10px; /* Padding for better spacing */
    border: 3px solid #ccc; /* Light gray border */
    border-radius: 4px; /* Rounded corners */
    background-color: #fff; /* White background */
    font-size: 16px; /* Font size */
    color: #333; /* Text color */
    cursor: pointer; /* Pointer cursor on hover */
    transition: border-color 0.3s; /* Smooth transition for border color */
    margin-bottom: 100px;
}

.styled-select:focus {
    border-color: #007bff; /* Change border color on focus */
    outline: none; /* Remove default outline */
}

.styled-select option {
    padding: 10px; /* Padding for options */
}


table {
  width: 100%; /* Занимает всю ширину окна */
  margin-bottom: 100px;
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

  .table-cell {
    max-width: 250px; /* Set your desired max width */
    // overflow: hidden; /* Hide overflow content */
    // text-overflow: ellipsis; /* Add ellipsis for overflowed text */
    // white-space: wrap; /* Prevent text from wrapping */
    overflow-wrap: break-word;
    word-break: break-word;
}
</style>