class UserService {
    axios
    baseUrl

    constructor(axios, baseURL) {
        this.axios = axios
        this.baseUrl = baseURL
    }

    get(id) {
        let self = this;
        return self.axios.get(`${self.baseUrl}users/${id}`);
    }

    refreshClaims() {
        window.location.href = '/auth/refresh';
    }
}

export default UserService