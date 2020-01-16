import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'home',
    component: () => import(/* webpackChunkName: "about" */ '../views/Home.vue')
  },
  {
    path: '/vip',
    name: 'vip',
    component: () => import(/* webpackChunkName: "about" */ '../views/Vip.vue')
  },
  {
    path: '/add',
    name: 'add',
    component: () => import(/* webpackChunkName: "about" */ '../views/Add.vue')
  },
  {
    path: '/notice',
    name: 'notice',
    component: () => import(/* webpackChunkName: "about" */ '../views/Notice.vue')
  },
  {
    path: '/mine',
    name: 'mine',
    component: () => import(/* webpackChunkName: "about" */ '../views/Mine.vue')
  }
]

const router = new VueRouter({
  routes
})

export default router
