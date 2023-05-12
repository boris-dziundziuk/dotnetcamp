// Find all the img tags on the page
const imgTags_ = document.getElementsByTagName('img');

// Loop through each img tag
for (let i = 0; i < imgTags_.length; i++) {
  const imgTag_ = imgTags_[i];
  const imgUrl_ = imgTag_.getAttribute('src');

  // Check if the URL contains .mp3
  if (imgUrl_.includes('.mp3')) {
    // Replace the whole URL with a new one that has .jpg extension
    const newImgUrl = imgUrl_.replace(/.*/gi, 'https://nftagora.io/wp-content/uploads/audio.png').replace("https://nftagora.io/wp-content/uploads/audio.pnghttps://nftagora.io/wp-content/uploads/audio.png", "https://nftagora.io/wp-content/uploads/audio.png");
    console.log(newImgUrl)
    imgTag_.setAttribute('src', newImgUrl);
  }

  if (imgUrl_.includes('.mp4')) {
    // Replace the whole URL with a new one that has .jpg extension
    const newImgUrl = imgUrl_.replace(/.*/gi, 'https://nftagora.io/wp-content/uploads/video.png').replace("https://nftagora.io/wp-content/uploads/video.pnghttps://nftagora.io/wp-content/uploads/video.png", "https://nftagora.io/wp-content/uploads/video.png");
    console.log(newImgUrl)
    imgTag_.setAttribute('src', newImgUrl);
  }
}