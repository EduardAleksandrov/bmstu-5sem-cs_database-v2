import { createStore } from 'vuex'
import suppliers from './modules/suppliers'
import warehouses from './modules/warehouses'

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
  }
})
