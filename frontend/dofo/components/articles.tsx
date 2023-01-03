import { IArticle } from "../types/interfaces/article"

import Layout from "./layout"
import ArticleBlock from "./article-block";

const articles: React.FC<{ articles: IArticle[] }> = ({ articles }) => {

    return (
        <Layout>
        <div className="flexx w-full">
            {articles.map((article) => {
                return <ArticleBlock key={article.id} title={article.title}
                    imageUrl="/../public/images/logo.jpg"
                    description={article.description}
                    Url={`/articles/${article.id}` }
                />
            })}
        </div>
        </Layout>
    )
}

export default articles