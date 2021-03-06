class BuyService {
    axios
    baseUrl

    constructor(axios, baseURL) {
        this.axios = axios
        this.baseUrl = baseURL
    }

    create(model) {
        let self = this;
        return self.axios.post(`${self.baseUrl}userProducts`, model);
    }

    getAll(id){
        let self = this;
        return self.axios.get(`${self.baseUrl}userProducts/${id}`);
    }

}

export default BuyService