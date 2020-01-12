import Vue from 'vue'
import App from './App.vue'
import router from './router/router.js'
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

// 使用rem布局设置
const setHtmlFontSize = () => {
  const htmlDom = document.getElementsByTagName('html')[0]
  let htmlWidth = document.documentElement.clientWidth || document.body.clientWidth
  if (htmlWidth >= 750) {
    htmlWidth = 750
  }
  if (htmlWidth <= 320) {
    htmlWidth = 320
  }
  htmlDom.style.fontSize = `${htmlWidth / 7.5}px`
}
window.onresize = setHtmlFontSize
setHtmlFontSize()

Vue.use(ElementUI)

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
