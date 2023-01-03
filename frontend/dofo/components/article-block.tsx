import Image from 'next/image';
import Link from 'next/link';

const ArticleBlock = (props:any) => {
  // let props:any = {Url:'/'}
  return (
    <div className="w-1/4 shadow-xl rounded-lg p-1 flex-1 ">
      <Image
        className='w-96'
        src={ props.imageUrl} // Route of the image file
    height={144} // Desired size with correct aspect ratio
    width={144} // Desired size with correct aspect ratio
    alt="Dofo logo"
      />
      <div className='p-2'>
<h2 className="text-sm font-medium">{props.title}</h2>
      <p className="text-xs leading-6">{props.description}</p>
      <div className='flex justify-between mt-1'>
        <Link href={props.Url}>Read More</Link><p>Share icons</p>
      </div>
      </div>
      
      </div>
  );
}

export default ArticleBlock;
