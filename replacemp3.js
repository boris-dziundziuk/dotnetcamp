// get all img tags in the document
const imgTags = document.getElementsByTagName("img");

// loop through each img tag
for (let i = 0; i < imgTags.length; i++) {
  const imgTag = imgTags[i];

  // check if the img tag's src attribute contains a link to an mp3 file
  if (imgTag.src.toLowerCase().endsWith(".mp3")) {
    
    // create an audio element and set its src attribute to the mp3 link
    const audioElement = document.createElement("audio");
    audioElement.src = imgTag.src;

    // set the audio element attributes for autoplay, loop and controls
    audioElement.autoplay = true;
    audioElement.loop = true;
    audioElement.controls = true;

    // replace the img tag with the audio element
    imgTag.parentNode.replaceChild(audioElement, imgTag);
  }
}