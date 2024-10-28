import axios from "axios";

let api_url = process.env.VUE_APP_API_URL;
let url = `${api_url}/api/customers/`;

export default {
    namespaced: true,
    actions: {
        async fetchCustomers({commit}) 
        {
            try {
                const customers = await axios.get(url);
                commit('setCustomers', customers.data);
            } catch (e) {
                console.log(e.message);
            }
        },
        async newCustomers({commit, dispatch}, payload) 
        {
            try {
                const response = await axios.post(url, payload, 
                    {
                    headers: {
                        'Content-Type': 'application/json',
                    }
                });
                console.log('Response:', response.data);

                await dispatch("fetchCustomers");
            } catch (e) {
                console.log(e.message);
            }
        },
        async deleteCustomer({commit, dispatch}, payload) 
        {
            let url_d = `${url}${payload.iD_Customer}`;
            try {
                const response = await axios.delete(url_d);
                console.log('Response:', response.data);
                await dispatch("fetchCustomers");
            } catch (e) {
                console.log(e.message);
            }
        },
        async updateCustomer({commit, dispatch}, payload) {
            let url_d = `${url}${payload.iD_Customer}`;
            try {
                await axios.put(url_d, payload,
                {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                });
                // await dispatch("fetchCustomers");
                commit('updateCustomer', payload);
            } catch (e) {
                console.log(e.message);
            }
        }
        
    },
    mutations: {
        setCustomers(state, customers) 
        {
            state.customersList = customers;
        },
        setPage(state, number)
        {
            state.page = number;
        },
        showModal(state, payload) {
            state.modal = payload;
        },
        setCurrentEl(state, payload)
        {
            state.currentElementForModal = payload;
        },
        updateCustomer(state, payload)
        {
            const index = state.customersList.findIndex(customer => customer.iD_Customer === payload.iD_Customer);

            if (index !== -1) {
                // Replace the old customer with the new customer object
                state.customersList[index] = payload;
            } else {
                console.log('Customer not found');
            }
        },
        changeSort(state, payload)
        {
            state.sorting = payload;
        }
    },
    state: {
        customersList: [],
        itemsPerPage: 2,
        page: 1,
        modal: false, //показывать модалку
        currentElementForModal:{},
        sorting: 0,
    },
    getters: {
        allCustomers: (state) => state.customersList,
        getTotalPages: (state) => Math.ceil(state.customersList.length / state.itemsPerPage),
        getPage: (state) => state.page,
        getCustomersByPage(state)
        {
            let s = state.customersList.map((element) => element);

            if(state.sorting == 1)
            {
                s.sort((a, b) => {
                    return a.customerName.localeCompare(b.customerName);
                });
            } else if(state.sorting == 2)
            {
                s.sort((a, b) => {
                    return b.customerName.localeCompare(a.customerName);
                });
            }

            return s.splice(state.itemsPerPage*state.page - state.itemsPerPage, state.itemsPerPage);
        },
        getModalState: (state) => state.modal,
        getcurrentElementForModal: (state) => state.currentElementForModal,
    }
}