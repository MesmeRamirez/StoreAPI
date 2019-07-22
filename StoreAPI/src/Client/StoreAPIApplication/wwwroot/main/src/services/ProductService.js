class ProductService {
    axios
    baseUrl

    constructor(axios, baseURL) {
        this.axios = axios
        this.baseUrl = baseURL
    }

    get(id) {
        let self = this;
        return self.axios.get(`${self.baseUrl}products/${id}`);
    }

    getAll(take, filter){
        let self = this;
        let query = 'take=${take}&filter=${JSON.stringify(filter)}';
        return self.axios.get(`${self.baseUrl}products?${query}`);
    }

}

export default ProductService