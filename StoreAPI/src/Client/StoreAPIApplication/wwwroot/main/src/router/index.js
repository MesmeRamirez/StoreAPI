import Vue from 'vue'
import Router from 'vue-router'

import UserInfo from '@/components/user/information'
import AddProducts from '@/components/products/createProducts'
import EditProducts from '@/components/products/editProducts'
import ManageProducts from '@/components/products/manageProducts'
import ListProducts from '@/components/products/Product'
import ListBuyProducts from '@/components/products/listProducts'
import ExampleIndex from '@/components/example/Index'
import ExampleView from '@/components/example/View'

Vue.use(Router)

const routes = [
  { path: '/user-information', name: 'UserInfo', component: UserInfo },
  { path: '/add-products', name: 'AddProducts', component: AddProducts },
  { path: '/products/:id/edit', name: 'EditProducts', component: EditProducts },
  { path: '/manage-products', name: 'ManageProducts', component: ManageProducts },
  { path: '/products', name: 'ListProducts', component: ListProducts },
  { path: '/', name: 'ListBuyProducts', component: ListBuyProducts },
  { path: '/example', name: 'ExampleIndex', component: ExampleIndex },
  { path: '/example/:id', name: 'ExampleView', component: ExampleView },
]

export default new Router({
  routes
})
