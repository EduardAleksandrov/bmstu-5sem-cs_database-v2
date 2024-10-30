<template>
    <div class="form">
        <div class="form__wrapper">
            <div class="form__text-wrapper">
                <h1>
                    Форма
                </h1>
                <br>
                <div class="form__text-title">Статус</div>
                <select v-model="status" id="options" :class="['styled-select', {'yellow-border': !orderlistsYBorder}]">
                    <option v-for="option in st" :key="option" :value="option">
                        {{ option }}
                    </option>
                </select>                
                
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
    name: 'OrderlistsModal',
    data() {
        return {
            iD_Order: null,
            customerID: null,
            totalAmount: null,
            orderDate: null,
            status: null,
            st: [
                'Opened',
                'Completed',
                'Shipped',
                'Pending',
                'Closed'
            ]
        };
    },
    mounted() {
        this.iD_Order = this.getcurrentElementForModal.iD_Order;
        this.customerID = this.getcurrentElementForModal.customerID;
        this.totalAmount = this.getcurrentElementForModal.totalAmount;
        this.orderDate = this.getcurrentElementForModal.orderDate;
        this.status = this.getcurrentElementForModal.status;
    },
    watch: {
    },  
    methods: {
        ...mapMutations('orderlists', ['showModal']),
        ...mapActions('orderlists', ['updateOrderlist']),
        closeModal() {
            this.showModal(false);
        },
        saveChanges() 
        {
            let obj = {
                iD_Order: this.iD_Order,
                customerID: this.customerID,
                totalAmount: this.totalAmount,
                orderDate: this.orderDate,
                status: this.status,
            }
            this.updateOrderlist(obj);
            this.showModal(false);
        }
    },
    computed: {
        ...mapGetters('orderlists', ['getcurrentElementForModal']),
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
    margin-bottom: 100px;
}

.styled-select:focus {
    border-color: #007bff; /* Change border color on focus */
    outline: none; /* Remove default outline */
}

.styled-select option {
    padding: 10px; /* Padding for options */
}
</style>