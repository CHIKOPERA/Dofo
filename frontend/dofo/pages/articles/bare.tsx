import ArticleBlock from "../../components/article-block"
import { IArticle } from "../../types/interfaces/article"
import { getArticlesApi } from "../api/articles-api"
import Articles from "../../components/articles"

export const getStaticProps = async () => {
    let res = await getArticlesApi()
    
    return {
        props: {
            articles: await res
        }
    }
}

const articles = (props: any) => {
    let articles : IArticle[] =  props.articles

    return <Articles articles={articles } />
}

export default articles