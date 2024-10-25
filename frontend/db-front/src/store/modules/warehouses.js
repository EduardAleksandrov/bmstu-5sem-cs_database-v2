import axios from "axios";

let api_url = process.env.VUE_APP_API_URL;
let url = `${api_url}/api/warehouses/`;

export default {
    namespaced: true,
    actions: {
        async fetchWarehouses({commit}) 
        {
            try {
                const warehouses = await axios.get(url);
                commit('setWarehouses', warehouses.data);
            } catch (e) {
                console.log(e.message);
            }
        },
        async newWarehouses({commit, dispatch}, payload) 
        {
            try {
                const response = await axios.post(url, payload, 
                    {
                    headers: {
                        'Content-Type': 'application/json',
                    }
                });
                console.log('Response:', response.data);

                await dispatch("fetchWarehouses");
            } catch (e) {
                console.log(e.message);
            }
        },
        async deleteWarehouse({commit, dispatch}, payload) 
        {
            let url_d = `${url}${payload.iD_Warehouse}`;
            try {
                const response = await axios.delete(url_d);
                console.log('Response:', response.data);
                await dispatch("fetchWarehouses");
            } catch (e) {
                console.log(e.message);
            }
        },
        async updateWarehouse({commit, dispatch}, payload) {
            let url_d = `${url}${payload.iD_Warehouse}`;
            try {
                await axios.put(url_d, payload,
                {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                });
                // await dispatch("fetchSuppliers");
                commit('updateWarehouse', payload);
            } catch (e) {
                console.log(e.message);
            }
        }
        
    },
    mutations: {
        setWarehouses(state, warehouses) 
        {
            state.warehousesList = warehouses;
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
        updateWarehouse(state, payload)
        {
            const index = state.warehousesList.findIndex(warehouse => warehouse.iD_Warehouse === payload.iD_Warehouse);

            if (index !== -1) {
                // Replace the old warehouse with the new warehouse object
                state.warehousesList[index] = payload;
            } else {
                console.log('Supplier not found');
            }
        }
    },
    state: {
        warehousesList: [],
        itemsPerPage: 2,
        page: 1,
        modal: false, //показывать модалку
        currentElementForModal:{},
    },
    getters: {
        allWarehouses: (state) => state.warehousesList,
        getTotalPages: (state) => Math.ceil(state.warehousesList.length / state.itemsPerPage),
        getPage: (state) => state.page,
        getWarehousesByPage(state)
        {
            let s = state.warehousesList.map((element) => element);
            return s.splice(state.itemsPerPage*state.page - state.itemsPerPage, state.itemsPerPage);
        },
        getModalState: (state) => state.modal,
        getcurrentElementForModal: (state) => state.currentElementForModal,
    }
}