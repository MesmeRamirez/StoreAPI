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

    /*getAll(take, filter){
        let self = this;
        //let query = 'take=${take}&filter=${JSON.stringify(filter)}';
        let query = 'take=10';
        return self.axios.get(`${self.baseUrl}products?${query}`);
    }*/

    getAll(){
        let self = this;
        return self.axios.get(`${self.baseUrl}products`);
    }

    partial(id, params) {
        let self = this;
        return self.axios.patch(`${self.baseUrl}products/${id}`, params);
    }

    image(id, file) {
        let self = this;
        return self.axios.put(`${self.baseUrl}/${id}/image`, file);
    }

    create(model) {
        let self = this;
        return self.axios.post(`${self.baseUrl}products`, model);
    }

    remove(id) {
        let self = this;
        return self.axios.delete(`${self.baseUrl}products/${id}`);
    }

}

export default ProductService