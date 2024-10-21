import axios from "axios";

let url = 'http://127.0.0.1:5132/api/suppliers/';

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
        
    },
    state: {
        suppliersList: [],
    },
    getters: {
        allSuppliers: (state) => state.suppliersList,
    }
}