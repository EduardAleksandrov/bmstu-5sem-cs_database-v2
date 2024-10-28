import axios from "axios";

let api_url = process.env.VUE_APP_API_URL;
let url = `${api_url}/api/products/`;

export default {
    namespaced: true,
    actions: {
        async fetchProducts({commit}) 
        {
            try {
                const products = await axios.get(url);
                commit('setProducts', products.data);
            } catch (e) {
                console.log(e.message);
            }
        },
        async newProducts({commit, dispatch}, payload) 
        {
            try {
                const response = await axios.post(url, payload, 
                    {
                    headers: {
                        'Content-Type': 'application/json',
                    }
                });
                console.log('Response:', response.data);

                await dispatch("fetchProducts");
            } catch (e) {
                console.log(e.message);
            }
        },
        async deleteProduct({commit, dispatch}, payload) 
        {
            let url_d = `${url}${payload.iD_Product}`;
            try {
                const response = await axios.delete(url_d);
                console.log('Response:', response.data);
                // console.log(payload);
                await dispatch("fetchProducts");
            } catch (e) {
                console.log(e.message);
            }
        },
        async updateProduct({commit, dispatch}, payload) {
            let url_d = `${url}${payload.iD_Product}`;
            try {
                await axios.put(url_d, payload,
                {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                });
                commit('updateProduct', payload);
            } catch (e) {
                console.log(e.message);
            }
        }
        
    },
    mutations: {
        setProducts(state, products) 
        {
            state.productsList = products;
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
        updateProduct(state, payload)
        {
            const index = state.productsList.findIndex(product => product.iD_Product === payload.iD_Product);

            if (index !== -1) {
                // Replace the old product with the new product object
                state.productsList[index] = payload;
            } else {
                console.log('Product not found');
            }
        },
        changeSort(state, payload)
        {
            state.sorting = payload;
        }
    },
    state: {
        productsList: [],
        itemsPerPage: 2,
        page: 1,
        modal: false, //показывать модалку
        currentElementForModal:{},
        sorting: 0,
    },
    getters: {
        allProducts: (state) => state.productsList,
        getTotalPages: (state) => Math.ceil(state.productsList.length / state.itemsPerPage),
        getPage: (state) => state.page,
        getPageProduct: (state) => state.page,
        getProductsByPage(state)
        {
            let s = state.productsList.map((element) => element);

            if(state.sorting == 1)
            {
                s.sort((a, b) => {
                    return a.productName.localeCompare(b.productName);
                });
            } else if(state.sorting == 2)
            {
                s.sort((a, b) => {
                    return b.productName.localeCompare(a.productName);
                });
            }

            return s.splice(state.itemsPerPage*state.page - state.itemsPerPage, state.itemsPerPage);
        },
        getModalState: (state) => state.modal,
        getcurrentElementForModal: (state) => state.currentElementForModal,
    }
}