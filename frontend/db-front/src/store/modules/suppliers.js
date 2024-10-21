import axios from "axios";

export default {
    namespaced: true,
    actions: {
        async fetchSuppliers({commit}) 
        {
            try {
                const suppliers = await axios.get('http://127.0.0.1:5132/api/suppliers');
                commit('setSuppliers', suppliers.data);
            } catch (e) {
                console.log(e.message);
            }
        },
        async newSuppliers({commit, dispatch}, payload) 
        {
            try {
                const response = await axios.post('http://127.0.0.1:5132/api/suppliers', payload, 
                    {
                    headers: {
                        'Content-Type': 'application/json',
                    }
                });
                console.log('Response:', response.data);
                console.log("hello");

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