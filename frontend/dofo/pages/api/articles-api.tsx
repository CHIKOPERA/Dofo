import { IArticle } from "../../types/interfaces/article"

export const getArticlesApi = async () => {
    let res = await fetch("https://63b3ef16ea89e3e3db51683a.mockapi.io/api/article")
    
    return await res.json()
}

export const getArticle = async (id:string) => {
    let res = await fetch(`https://63b3ef16ea89e3e3db51683a.mockapi.io/api/article/${id}`)

    return await res.json()
}