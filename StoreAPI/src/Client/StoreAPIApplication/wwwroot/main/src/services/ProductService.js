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

    partial(id, params) {
        let self = this;
        return self.axios.patch(`${self.baseUrl}/${id}`, params);
    }

    image(id, file) {
        let self = this;
        return self.axios.put(`${self.baseUrl}/${id}/image`, file);
    }

    create(model) {
        let self = this;
        return self.axios.post(`${self.baseUrl}products`, model);
    }

}

export default ProductService