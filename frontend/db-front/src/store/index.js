import { createStore } from 'vuex'
import suppliers from './modules/suppliers'
import warehouses from './modules/warehouses'
import customers from './modules/customers'
import products from './modules/products'
import orderlists from './modules/orderlists'

export default createStore({
  state: {
  },
  getters: {
  },
  mutations: {
  },
  actions: {
  },
  modules: {
    suppliers: suppliers,
    warehouses: warehouses,
    customers: customers,
    products: products,
    orderlists: orderlists,
  }
})
