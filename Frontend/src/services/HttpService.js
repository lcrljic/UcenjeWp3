import axios from "axios";

export const HttpService = axios.create({

    baseURL: 'lcrljic-001-site1.ktempurl.com',
    headers: {
        'Content-Type' : 'application/json'
    }

});