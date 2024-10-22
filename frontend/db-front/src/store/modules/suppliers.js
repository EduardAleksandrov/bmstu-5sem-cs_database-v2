import axios from "axios";

let api_url = process.env.VUE_APP_API_URL;
let url = `${api_url}/api/suppliers/`;

export default {
    namespaced: true,
    actions: {
        async fetchSuppliers({commit}) 
        {
            try {
                const suppliers = await axios.get(url);
                commit('setSuppliers', suppliers.data);
            } catch (e) {
                console.log(e.message);
            }
        },
        async newSuppliers({commit, dispatch}, payload) 
        {
            try {
                const response = await axios.post(url, payload, 
                    {
                    headers: {
                        'Content-Type': 'application/json',
                    }
                });
                console.log('Response:', response.data);

                await dispatch("fetchSuppliers");
            } catch (e) {
                console.log(e.message);
            }
        },
        async deleteSupplier({commit, dispatch}, payload) 
        {
            let url_d = `${url}${payload.iD_Supplier}`;
            try {
                const response = await axios.delete(url_d);
                console.log('Response:', response.data);
                // console.log(payload);
                await dispatch("fetchSuppliers");
            } catch (e) {
                console.log(e.message);
            }
        },
        
    },
    mutations: {
        setSuppliers(state, suppliers) 
        {
            state.suppliersList = suppliers;
        },
        setPage(state, number)
        {
            state.page = number;
        }
    },
    state: {
        suppliersList: [],
        itemsPerPage: 2,
        page: 1,
    },
    getters: {
        allSuppliers: (state) => state.suppliersList,
        getTotalPages: (state) => Math.ceil(state.suppliersList.length / state.itemsPerPage),
        getPage: (state) => state.page,
        getSuppliersByPage(state)
        {
            let s = state.suppliersList.map((element) => element);
            return s.splice(state.itemsPerPage*state.page - state.itemsPerPage, state.itemsPerPage);
        }
    }
}