<template>
    <div class="form">
        <div class="form__wrapper">
            <div class="form__text-wrapper">
                <h1>
                    Форма
                </h1>
                <br>
                <div class="form__text-title">Название поставщика</div>
                <input name="supplierName" :class="['form__text', {'yellow-border': !titleYBorder}, {'red-border': titleRBorder}]" v-model="supplierName" autocomplete="off" />
                <div class="form__text-title">Контактное имя</div>
                <input name="contactName" :class="['form__text', {'yellow-border': !authorYBorder}, {'red-border': authorRBorder}]" v-model="contactName" autocomplete="off" />
                <div class="form__text-title">Email</div>
                <input name="email" :class="['form__text', {'yellow-border': !imgtypeYBorder}, {'red-border': imgtypeRBorder}]" v-model="email" autocomplete="off" />
                <div class="form__text-title">Phone</div>
                <input name="phone" :class="['form__text', {'yellow-border': !imgdateYBorder}, {'red-border': imgdateRBorder}]" v-model="phone" autocomplete="off" />

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
    name: 'SupplirsModal',
    data() {
        return {
            iD_Supplier: null,
            supplierName: null,
            contactName: null,
            email: null,
            phone: null
        };
    },
    mounted() {
        this.iD_Supplier = this.getcurrentElementForModal.iD_Supplier,
        this.supplierName = this.getcurrentElementForModal.supplierName,
        this.contactName = this.getcurrentElementForModal.contactName,
        this.email = this.getcurrentElementForModal.email,
        this.phone = this.getcurrentElementForModal.phone
        
    },
    watch: {
    },  
    methods: {
        ...mapMutations('suppliers', ['showModal']),
        ...mapActions('suppliers', ['updateSupplier']),
        closeModal() {
            this.showModal(false);
        },
        saveChanges() {
            if (this.supplierName === '' || this.contactName === '' || this.email === '' || this.phone === '') {
                return
            } else {
                let obj = {
                    iD_Supplier: this.iD_Supplier,
                    supplierName: this.supplierName,
                    contactName: this.contactName,
                    email: this.email,
                    phone: this.phone
                }
                this.updateSupplier(obj);
                this.showModal(false);
            }
        }
    },
    computed: {
        ...mapGetters('suppliers', ['getcurrentElementForModal']),
        emptyInputs() {
            return this.supplierName === '' || this.contactName === '' || this.email === '' || this.phone === '';
        },
        titleYBorder() {
            return this.getcurrentElementForModal.supplierName === this.supplierName;
        },
        titleRBorder() {
            return this.supplierName === ''
        },
        authorYBorder() {
            return this.getcurrentElementForModal.contactName === this.contactName;
        },
        authorRBorder() {
            return this.contactName === ''
        },
        imgtypeYBorder() {
            return this.getcurrentElementForModal.email === this.email;
        },
        imgtypeRBorder() {
            return this.email === ''
        },
        imgdateYBorder() {
            return this.getcurrentElementForModal.phone=== this.phone;
        },
        imgdateRBorder() {
            return this.phone === ''
        }
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
</style>