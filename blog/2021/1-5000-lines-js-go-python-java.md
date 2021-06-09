I wrote 5000 lines of code with JS, Go, Python and Java

I'm member of the SDK and SDK tooling team at IBM Labs Budapest where our mission is providing tooling for service teams
so they can easily release SDKs for their services. In the last month I worked on integration tests of the SDK for a
service going to be released in the near future. Working on this task I wrote ~5000 lines of code for each SDK, which is
Node, Java, Python and Go. In this article I'm going to share my experience. 

Disclaimer, this is not a comparison of these languages and tools they have. It is an opinion and, possibly, a list of 
lessons I learned. I'm barely experienced with Python and Go but my limited experience was enough to write the tests and
gain, rather volumetric, experience.

Java
Using java in the context of the 4 languages it is clear that it is way more verbose than the other three, but I don't
have any problem with that. The only pain point is maven. The project consists of 10+ modules and I edit one. If even
only the changed module is compiled maven goes through all modules and checks whether the are changed or not. It takes a
lot of time, especially when you execute your tests frequently. It is just not effective. I started with java and
building up the initial test set took way more time than it should due to that maven is slow. Implementing the same test
cases took third or fourth of the time for each languages from the other three.

What I really like in java is the excellent support IntelliJ provides. Working wiht java is great. I also have to add
that I'm comfortable working with java, so possibly I'm biased.

The testing framework we use is TestNG, and the execution of these tests are totally different than the other three has.
TestNG executes test cases in random order so it is a best practice if you have independent tests. The other three
languages' test frameworks execute the test cases in sequential order. Since cohesion, similarity between the different SDK 
integration tests is a good thing - you can track the coverage more easily - java test cases had to accomodate to the
format/execution order we have in the other three languages. Meaning, I had to ensure that the file layout and execution
order is the same or very similar across SDKs. Even though TestNG provides an easy to use method to do so it took a few
tries to find the solution which makes the whole scalable and easy to maintain. 

Node/JS
JS is always the meh... language for me. Its flexibility is a pain because you just don't know what should be provided
for a method as parameter. It is still not comfortable - especally compared to java - when WebStorm provides excellent
support. The fact is that implementing the test cases is way faster than java.

I had a few clashes with Jest around whether console.log output happens or not due to lack of knowledge at my side. But
I could overcome this problem easily, I just had to read the manual!

Test execution is pretty fast, but what I'm missing is displaying the progress. You can get all the output you need once
all the tests are executed. So, you can't interrupt execution purposfully. Executing a single test case is a huge pain
in the neck from command line. I need to spend some time with WebStorm and experience how it can help.

Python
The pain with python after java and js is the tabs, and due to that copy-paste habits must be aligned. One have to copy
whole lines not only the content of a line in order to keep up the tabs which are an important thing in python. It gave
me a little pain while I found what works well. PyCharm helped a lot.

Snake case drives my crazy. By volume I wrote the most code in C#, which is PascalCase. Switching to either java or JS
is not a problem because camel case is close to that. But snake case with the stupid _ character is a pain. It took an
hour to get use to it.

What I really like is the test execution PyTest provides. You have progress, you have verbose mode and a decent output.
Blazing fast, so it fits very nicely to a frequent execution method. Honestly, I should have start the whole testing
thing with python. I dont' like that python is a dynamic language, but its support in testing is great.

