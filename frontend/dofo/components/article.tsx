import { IArticle } from "../types/interfaces/article"

import Layout from "./layout"
import Image from 'next/image';

const article: React.FC<{ articleContents: IArticle }> = ({ articleContents }) => {
     return <Layout>
         <article>
             <h2>{articleContents.title}</h2>
             <div>
                 <Image
                     className='w-96'
                     src={''} // Route of the image file
                     height={144} // Desired size with correct aspect ratio
                     width={144} // Desired size with correct aspect ratio
                     alt="Dofo logo"
                 />
             </div>
             <p>
                 { articleContents.body}
             </p>
        </article>
    </Layout>
}

export default article