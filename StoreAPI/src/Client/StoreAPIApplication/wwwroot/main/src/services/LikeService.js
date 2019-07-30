class LikeService {
    axios
    baseUrl

    constructor(axios, baseURL) {
        this.axios = axios
        this.baseUrl = baseURL
    }

    create(model) {
        let self = this;
        return self.axios.post(`${self.baseUrl}likes`, model);
    }

    remove(id) {
        let self = this;
        return self.axios.delete(`${self.baseUrl}likes/${id}`);
    }

}

export default LikeService