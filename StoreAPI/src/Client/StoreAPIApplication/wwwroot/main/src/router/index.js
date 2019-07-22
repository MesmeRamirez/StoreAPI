import Vue from 'vue'
import Router from 'vue-router'

import Default from '@/components/Default'
import UserInfo from '@/components/user/information'
import AddProducts from '@/components/products/createProducts'
import ListProducts from '@/components/products/Product'
import ExampleIndex from '@/components/example/Index'
import ExampleView from '@/components/example/View'

Vue.use(Router)

const routes = [
  { path: '/', name: 'Default', component: Default },
  { path: '/user-information', name: 'UserInfo', component: UserInfo },
  { path: '/add-products', name: 'AddProducts', component: AddProducts },
  { path: '/products', name: 'ListProducts', component: ListProducts },
  { path: '/example', name: 'ExampleIndex', component: ExampleIndex },
  { path: '/example/:id', name: 'ExampleView', component: ExampleView },
]

export default new Router({
  routes
})
