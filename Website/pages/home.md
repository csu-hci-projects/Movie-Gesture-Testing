

# Project Title
***Evaluating The Viability and Intuitiveness of Movie Gestures***
# Authors
**Dennon Meiklejohn, Todd Monitto**
# Description
This is the final project for CS464. This project is designed to start the conversation of what holographic gestures we should be attempting to implement into our technology once we become advanced enough to use
such a technology. We went through the following movies to test their hologram gesture intuitiveness to users: Iron Man, Her, Prometheus. When deciding how to build these scenes we determined that we wanted to eliminate any
potential visual clutter that could cause the results to become skewed as a result of a flashier scene for a particular movie. Due to this we decided to boil our gestures down into the simplest possible Objects.
For example our "Her" experiment (Pictured Below) involves only the user and 2 human models that we can use gestures with. This allows the user to immediately know what they are looking at and once told their objective they immediately
know what object we are referring to.
![Screenshot of 'Her' simulation](./images/image.png)
# Motivation
Our motivation behind this stems from the fact that there are almost no academic studies that were made on hologram gesture viability, and we thought that it was necessary for us to figure this out now so we can build
the technology around these gestures. We decided to pull our gestures from pop culture to see if those could be potentially viable, as that is how many people in our current world picture hologram interactions so there is some
form of background knowledge on how to interact with similar devices.
# Methodology

**Experiment Design**  
The simulated environment that we created was through the use of Unity and an Oculus Rift headset. The Oculus rift is a full VR headset that allows us to create a very specific virtual world for the user to interact with.
We leveraged the Wizard of Oz approach in order to give us more mobility with our objects being manipulated as an automated system would be less precise and potentially complete the gesture when the user did not mean to.  
Image of the unity editor is pictured below
![Screenshot of Unity](./images/image2.png)
The experiment involves the user being placed into the simulation and being told what their goal is, but not what the gesture is that they are meant to be doing to accomplish this. We then start a timer and keep track
of each time they attempt to use a gesture that is not the similar to that of the movie we are testing. What this allows us to do is to see which of these movies have gestures that users can intuitively decipher themselves
in a short period of time with a low error rate. If the movie ended up with a low error rate per gesture of under 3 and an average time per gesture of below 15 seconds, we classified it as intuitive and a potential candidate
for future technology. Each individual movie has its own flow that the user will go through attempting to find the gestures for each that corresponds to the actual flow used within that particular movie, and the data collected
will be averaged into one value for each movie.   

We Put the users into 3 "Groups", which we used to set the ordering of which movie they will be doing in order to remove any bias due to learning a similar gesture potentially from a previous experiment

**Participants**  
As a result of COVID-19 our experiment was not conducted in person. Instead it was carried out using a desktop sharing application "TeamViewer". We found willing individuals that possessed their own Oculus Rift and asked them to
participate, and those that accepted were given the program and allowed us access to their desktop so we could run the experiment via our Wizard of Oz approach remotely. Those with VR headsets at home also brought their roommates and family
in to the experiment to allow us additional participants that may not be as experienced in the virtual reality technology

Following the experiment we asked the participants the following questions in an exit survey to gather additional data:  
On a scale of 1 to 5 (1 being the lowest, 5 being the highest), how natural did the first gesture feel?  
On a scale of 1 to 5 (1 being the lowest, 5 being the highest), how natural did the second gesture feel?  
On a scale of 1 to 5 (1 being the lowest, 5 being the highest), how natural did the third gesture feel?  
How many movies do you watch a month?  
Which of the 3 movies have you seen?  
Have you used VR before? If so how often?  
Have you used AR before? If so how often?  
# Results
The results are as follows for each movie:  
**Iron Man**:  
Average Time/Gesture: 7.59 seconds  
Average Errors/Gesture: 1.48  
**Her**:  
Average Time/Gesture: 43 seconds  
Average Errors/Gesture:  8.11  
**Prometheus**:  
Average Time/Gesture:  3.72 seconds
Average Errors/Gesture:  0.47
# Conclusion
Of the movies we tested, it was found that Iron Man and Prometheus' gestures are intuitive enough to warrant further study and potential future use within hologram technology with Prometheus being classified as the most intuitive.
"Her" was found to not be intuitive with both error rate and time to complete being well above the threshhold of 15 seconds and 3 errors respectively and the users had a difficult time deciphering what gesture was used in the movie
for that particular task. More participants would be warranted in future studies in order to further prove these results are accurate.
# Links
Final Overview Video (short video): https://www.youtube.com/watch?v=SkCvwcb614U 
 
Final Presentation Video (long video): https://www.youtube.com/watch?v=6IeiWEz5A9w  

Github: https://github.com/csu-hci-projects/Movie-Gesture-Testing  
