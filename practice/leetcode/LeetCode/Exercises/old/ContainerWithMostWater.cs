namespace Exercises.old;

public class ContainerWithMostWater
{
    public static int Compute(int[] containers)
    {
        int containerSizeMax = 0;
        int left = 0;
        int right = containers.Length - 1;
        while (left < right)
        {
            // calculate size
            int width = right - left;
            int height = 0;

            // the shortest defines the container size
            if (containers[left] > containers[right])
            {
                height = containers[right];
            }
            else
            {
                height = containers[left];
            }

            int containerSize = width * height;
            // increase max if result is bigger
            if (containerSize > containerSizeMax)
            {
                containerSizeMax = containerSize;
            }

            if (containers[left] < containers[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return containerSizeMax;
    }
}