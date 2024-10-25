import { createStore } from 'vuex'
import suppliers from './modules/suppliers'
import warehouses from './modules/warehouses'
import customers from './modules/customers'

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
  }
})
