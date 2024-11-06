<template>
    <div class="form">
        <div class="form__wrapper">
            <div class="form__text-wrapper">
                <h1>
                    Форма
                </h1>
                <br>
                <div class="form__text-title">Поставщик</div>
                <select v-model="supplierID" id="options" :class="['styled-select', {'yellow-border': !supplierYBorder}]" size=2>
                    <option v-for="option in getSortSuppliers" :key="option.iD_Supplier" :value="option.iD_Supplier">
                        {{ option.supplierName }}
                    </option>
                </select>                
                <div class="form__text-title">Склад</div>
                <select v-model="warehouseID" id="options" class="styled-select" size=2>
                    <option v-for="option in getSortWarehouses" :key="option.iD_Warehouse" :value="option.iD_Warehouse">
                        {{ option.warehouseName }}
                    </option>
                </select>
                <div class="form__text-title">Название товара</div>
                <input name="productName" :class="['form__text', {'yellow-border': !titleYBorder}, {'red-border': titleRBorder}]" v-model="productName" autocomplete="off" />
                <div class="form__text-title">Производитель</div>
                <input name="producer" :class="['form__text', {'yellow-border': !authorYBorder}, {'red-border': authorRBorder}]" v-model="producer" autocomplete="off" />
                <div class="form__text-title">Складская ячейка</div>
                <input name="cell" :class="['form__text', {'yellow-border': !cellYBorder}, {'red-border': cellRBorder}]" v-model="cell" autocomplete="off" />
                <div class="form__text-title">Цена за единицу</div>
                <input name="unitPrice" :class="['form__text', {'yellow-border': !imgtypeYBorder}, {'red-border': imgtypeRBorder}]" v-model="unitPrice" autocomplete="off" />
                <div class="form__text-title">Количество на складе</div>
                <input name="quantityInStock" :class="['form__text', {'yellow-border': !imgdateYBorder}, {'red-border': imgdateRBorder}]" v-model="quantityInStock" autocomplete="off" />

                <div style="margin-bottom: 20px;">
                    <button class="form__text-submit" @click="saveChanges">Сохранить</button>
                    <button class="form__text-clear" @click="closeModal">Закрыть форму</button>
                </div>
                <div class="form__attention" v-if="emptyInputs">Поля не могут быть пустыми</div>
            </div>
        </div>
    </div>
</template>

<script>
import { mapGetters, mapState, mapMutations, mapActions } from 'vuex';
export default {
    name: 'ProductModal',
    data() {
        return {
            iD_Product: null,
            supplierID: null,
            warehouseID: null,
            productName: null,
            producer: null,
            cell: null,
            unitPrice: null,
            quantityInStock: null
        };
    },
    mounted() {
        this.iD_Product = this.getcurrentElementForModal.iD_Product,
        this.supplierID = this.getcurrentElementForModal.supplierID,
        this.warehouseID = this.getcurrentElementForModal.warehouseID,
        this.productName = this.getcurrentElementForModal.productName,
        this.producer = this.getcurrentElementForModal.producer,
        this.cell = this.getcurrentElementForModal.cell,
        this.unitPrice = this.getcurrentElementForModal.unitPrice,
        this.quantityInStock = this.getcurrentElementForModal.quantityInStock
        
    },
    watch: {
    },  
    methods: {
        ...mapMutations('products', ['showModal']),
        ...mapActions('products', ['updateProduct']),
        closeModal() {
            this.showModal(false);
        },
        saveChanges() {
            if (this.supplierID === '' || 
                this.warehouseID === '' || 
                this.productName === '' ||
                this.producer === '' ||
                this.cell === '' ||
                this.unitPrice === 0 ||
                this.quantityInStock === 0)
                {
                // console.log(this.supplierID);
                return
            } else {
                let obj = {
                    iD_Product: this.iD_Product,
                    supplierID: this.supplierID,
                    warehouseID: this.warehouseID,
                    productName: this.productName,
                    producer: this.producer,
                    cell: this.cell,
                    unitPrice: this.unitPrice,
                    quantityInStock: this.quantityInStock
                }
                this.updateProduct(obj);
                this.showModal(false);
            }
        }
    },
    computed: {
        ...mapGetters('products', ['getcurrentElementForModal']),
        ...mapGetters('suppliers', ['getSortSuppliers']),
        ...mapGetters('warehouses', ['getSortWarehouses']),
        emptyInputs() {
            return this.productName === '' || this.producer === '' || this.cell === '' || this.unitPrice === 0 || this.quantityInStock === 0 || this.unitPrice === '' || this.quantityInStock === '';
        },
        titleYBorder() {
            return this.getcurrentElementForModal.productName === this.productName;
        },
        titleRBorder() {
            return this.productName === '';
        },
        authorYBorder() {
            return this.getcurrentElementForModal.producer === this.producer;
        },
        authorRBorder() {
            return this.producer === '';
        },
        imgtypeYBorder() {
            return this.getcurrentElementForModal.unitPrice === this.unitPrice;
        },
        imgtypeRBorder() {
            return this.unitPrice === 0 || this.unitPrice === '';
        },
        imgdateYBorder() {
            return this.getcurrentElementForModal.quantityInStock === this.quantityInStock;
        },
        imgdateRBorder() {
            return this.quantityInStock === 0 || this.quantityInStock === '';
        },
        supplierYBorder() {
            return this.getcurrentElementForModal.supplierID === this.supplierID;
        },
        cellYBorder() {
            return this.getcurrentElementForModal.cell === this.cell;
        },
        cellRBorder() {
            return this.cell === '';
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

        min-width: 500px;
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

    // &__text-desc {
    //     width: 93%;
    //     height: 80px;
    //     margin-bottom: 40px;
    //     border: 1px solid rgb(185, 185, 185);
    //     border-radius: 4px;
    //     padding: 5px 10px;

    //     //margin-right: 80px;

    //     outline: none;
    //     &:focus {
    //         border: none;
    //         border-bottom: 3px solid rgb(207, 235, 50);
    //     }
    // }

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
</style>