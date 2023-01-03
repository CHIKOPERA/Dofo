import Link from 'next/link';
import Image from 'next/image';
import Head from 'next/head';
import Script from 'next/script';

import Layout from '../../components/layout';


const article = () => {
    return <Layout>
         <Head>
        <title>Articles</title>
        </Head>
         <Script
        src="https://connect.facebook.net/en_US/sdk.js"
        strategy="lazyOnload"
        onLoad={() =>
          console.log(`script loaded correctly, window.FB has been populated`)
        }
      />
        <Image
    src="/images/logo.jpg" // Route of the image file
    height={144} // Desired size with correct aspect ratio
    width={144} // Desired size with correct aspect ratio
    alt="Dofo logo"
  />
        sample article page
        <p>
            Goto <Link href="/articles/bare">this page!</Link>
        </p>
    </Layout>
}

export default article