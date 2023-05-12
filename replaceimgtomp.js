// get all img tags in the document
const imgTags = document.getElementsByTagName("img");

// loop through each img tag
for (let i = 0; i < imgTags.length; i++) {
  const imgTag = imgTags[i];

  // check if the img tag's src attribute contains a link to an mp3 file
  if (imgTag.src.toLowerCase().endsWith(".mp4")) {
    
    // create an audio element and set its src attribute to the mp3 link
    const videoElement = document.createElement("video");
    videoElement.src = imgTag.src;

    // set the audio element attributes for autoplay, loop and controls
    videoElement.autoplay = false;
    videoElement.loop = false;
    videoElement.controls = true;
    videoElement.width= 350;
    videoElement.height= 250;

    // replace the img tag with the audio element
    imgTag.parentNode.replaceChild(videoElement, imgTag);
  }

  if (imgTag.src.toLowerCase().endsWith(".mp3")) {
    
    // create an audio element and set its src attribute to the mp3 link
    const audioElement = document.createElement("audio");
    audioElement.src = imgTag.src;

    // set the audio element attributes for autoplay, loop and controls
    audioElement.autoplay = false;
    audioElement.loop = false;
    audioElement.controls = true;

    // replace the img tag with the audio element
    imgTag.parentNode.replaceChild(audioElement, imgTag);
  }
}