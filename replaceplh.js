// Find all the img tags on the page
const imgTags = document.getElementsByTagName('img');

// Loop through each img tag
for (let i = 0; i < imgTags.length; i++) {
  const imgTag = imgTags[i];
  const imgUrl = imgTag.getAttribute('src');

  // Check if the URL contains .mp3
  if (imgUrl.includes('.mp3')) {
    // Replace the whole URL with a new one that has .jpg extension
    const newImgUrl = imgUrl.replace(/\.mp3/gi, '/wp-content/uploads/audio.png');
    imgTag.setAttribute('src', newImgUrl);
  }

  if (imgUrl.includes('.mp4')) {
    // Replace the whole URL with a new one that has .jpg extension
    const newImgUrl = imgUrl.replace(/\.mp3/gi, 'video.png');
    imgTag.setAttribute('src', newImgUrl);
  }
}