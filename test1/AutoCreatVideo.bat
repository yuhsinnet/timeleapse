mkdir C:\Users\x7870\Pictures\TimeLeapseVideo
cd C:\Users\x7870\Pictures\TimeLeapsecam7
ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera7.avi

cd C:\Users\x7870\Pictures\TimeLeapsecam8
ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera8.avi

cd C:\Users\x7870\Pictures\TimeLeapsecam9
ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera9.avi

cd C:\Users\x7870\Pictures\TimeLeapsecam10
ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera10.avi

cd C:\Users\x7870\Pictures\TimeLeapsecam11
ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera11.avi

cd C:\Users\x7870\Pictures\TimeLeapsecam12
ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera12.avi
pause