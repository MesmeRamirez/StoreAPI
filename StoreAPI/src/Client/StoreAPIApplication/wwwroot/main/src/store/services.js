import Axios from 'axios'
import productService from '../services/ProductService'
import userService from '../services/UserService'

// Axios Configuration
Axios.defaults.headers.common.Accept = 'application/json'
Axios.defaults.headers.common.Authorization = 'bearer ${user.Token}'

export default {
    productService: new productService(Axios, window.Api.URL),
    userService: new userService(Axios, window.Api.URL)
}