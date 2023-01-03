import Article from '../../components/article';
import { IArticle } from '../../types/interfaces/article';
import { getArticlesApi, getArticle } from "../api/articles-api"


export const getStaticProps = async ({ params }:any) => {
    const article = await getArticle(params.id)

    return {
        props: {
            article: article
        }
    }
}

export const getStaticPaths = async () => {
    let articles: IArticle[] = await getArticlesApi();
    let paths = articles.map((article) => {
        return {
            params: {
                id: article.id
            },
        };
  });

    return {
        paths,
        fallback: false
    }
}

const article = ({ article }: any) => {    
    return <Article articleContents={ article} />
}

export default article