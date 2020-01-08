import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
// import './plugins/element.js'
import 'element-ui/lib/theme-chalk/index.css'
import Axios from 'axios'
import ElementUI from 'element-ui'

Vue.config.productionTip = false
// Axios.defaults.baseURL = '/apis'
// Axios.defaults.timeout = 5000
// Axios.defaults.headers = { 'Content-Type': 'application/json;charset=gb2312', 'Access-Control-Allow-Origin': '*' }
Vue.prototype.$axios = Axios

Vue.use(ElementUI)

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
