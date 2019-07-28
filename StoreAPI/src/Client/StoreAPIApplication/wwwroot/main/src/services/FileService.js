class FileService {
    axios
    baseUrl

    constructor() {
    }

    get(file) {
        let reader = new FileReader();
        reader.readAsDataURL(file);

        return new Promise((resolve, reject) => {
            try {
                reader.onload = () => {
                    resolve({
                        content: reader.result.split(',')[1],
                        name: name || file.name,
                        lenght: file.size,
                        contentType: file.type
                    })
                }
            } catch (error) {
                reject(error)
            } 
        })
    }

    refreshClaims() {
        window.location.href = '/auth/refresh';
    }
}

export default FileService