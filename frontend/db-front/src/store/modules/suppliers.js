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
        async updateSupplier({commit, dispatch}, payload) {
            let url_d = `${url}${payload.iD_Supplier}`;
            try {
                await axios.put(url_d, payload,
                {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                });
                // await dispatch("fetchSuppliers");
                commit('updateSupplier', payload);
            } catch (e) {
                console.log(e.message);
            }
        }
        
    },
    mutations: {
        setSuppliers(state, suppliers) 
        {
            state.suppliersList = suppliers;
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
        updateSupplier(state, payload)
        {
            const index = state.suppliersList.findIndex(supplier => supplier.iD_Supplier === payload.iD_Supplier);

            if (index !== -1) {
                // Replace the old supplier with the new supplier object
                state.suppliersList[index] = payload;
            } else {
                console.log('Supplier not found');
            }
        },
        changeSort(state, payload)
        {
            state.sorting = payload;
        }
    },
    state: {
        suppliersList: [],
        itemsPerPage: 2,
        page: 1,
        modal: false, //показывать модалку
        currentElementForModal:{},
        sorting: 0,
    },
    getters: {
        allSuppliers: (state) => state.suppliersList,
        getTotalPages: (state) => Math.ceil(state.suppliersList.length / state.itemsPerPage),
        getPage: (state) => state.page,
        getPageSupplier: (state) => state.page,
        getSuppliersByPage(state)
        {
            let s = state.suppliersList.map((element) => element);
            
            if(state.sorting == 1)
            {
                s.sort((a, b) => {
                    return a.supplierName.localeCompare(b.supplierName);
                });
            } else if(state.sorting == 2)
            {
                s.sort((a, b) => {
                    return b.supplierName.localeCompare(a.supplierName);
                });
            }

            return s.splice(state.itemsPerPage*state.page - state.itemsPerPage, state.itemsPerPage);
        },
        getModalState: (state) => state.modal,
        getcurrentElementForModal: (state) => state.currentElementForModal,
        getSortSuppliers(state) {
            // Create a shallow copy of the suppliersList to avoid mutating the original state
            let sortedSuppliers = [...state.suppliersList];
        
            // Sort the suppliers by supplierName using localeCompare
            sortedSuppliers.sort((a, b) => {
                return a.supplierName.localeCompare(b.supplierName);
            });
        
            return sortedSuppliers;
        }
    }
}