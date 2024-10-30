import axios from "axios";

let api_url = process.env.VUE_APP_API_URL;
let url = `${api_url}/api/orderlists/`;

export default {
    namespaced: true,
    actions: {
        async fetchOrderlists({commit}) 
        {
            try {
                const orders = await axios.get(url);
                commit('setOrderlists', orders.data);
            } catch (e) {
                console.log(e.message);
            }
        },
        async updateOrderlist({commit, dispatch}, payload) {
            let url_d = `${url}${payload.iD_Order}`;
            try {
                await axios.put(url_d, payload,
                {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                });
                // await dispatch("fetchSuppliers");
                commit('updateOrderlist', payload);
            } catch (e) {
                console.log(e.message);
            }
        }
        
    },
    mutations: {
        setOrderlists(state, orders) 
        {
            state.OrderlistList = orders;
        },
        setPage(state, number)
        {
            state.page = number;
        },
        showModal(state, payload) {
            state.modal = payload;
        },
        showOrderDetailsModal(state, payload) {
            state.orderDetailsModal = payload;
        },
        setCurrentEl(state, payload)
        {
            state.currentElementForModal = payload;
        },
        updateOrderlist(state, payload)
        {
            const index = state.OrderlistList.findIndex(order => order.iD_Order === payload.iD_Order);

            if (index !== -1) {
                // Replace the old warehouse with the new warehouse object
                state.OrderlistList[index] = payload;
            } else {
                console.log('Supplier not found');
            }
        },
        searchEmailMut(state, payload)
        {
            state.searchEmail = payload;
        },
        searchAllCustomers(state, payload)
        {
            state.searchAllCustomersM = payload;
        }
    },
    state: {
        OrderlistList: [],
        itemsPerPage: 5,
        page: 1,
        modal: false, //показывать модалку
        orderDetailsModal: false,
        currentElementForModal:{},
        searchEmail:'',
        searchAllCustomersM:[]
    },
    getters: {
        allOrderlists: (state) => state.OrderlistList,
        getTotalPages: (state) => Math.ceil(state.OrderlistList.length / state.itemsPerPage),
        getPage: (state) => state.page,
        getOrderlistsByPage(state, rootGetters)
        {
            let s = state.OrderlistList.map((element) => element);

            let allCustomers = state.searchAllCustomersM;
            if(state.searchEmail != '')
            {
                // Проверяем, что allCustomers существует и является массивом
                if (Array.isArray(allCustomers)) {
                    // Фильтруем клиентов по email
                    allCustomers = allCustomers.filter(user => 
                        user.email.toLowerCase().includes(state.searchEmail.toLowerCase())
                    );

                    // Если есть отфильтрованные клиенты, ищем соответствующие элементы в s
                    if (allCustomers.length > 0) {
                        s = s.filter(order => 
                            allCustomers.some(customer => customer.iD_Customer === order.customerID)
                        );
                    }
                } else {
                    console.error('allCustomers is undefined or not an array');
                }
            }

            return s.splice(state.itemsPerPage*state.page - state.itemsPerPage, state.itemsPerPage);
        },
        getModalState: (state) => state.modal,
        getModalOrderDetailsState: (state) => state.orderDetailsModal,
        getcurrentElementForModal: (state) => state.currentElementForModal,
    }
}