using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class ArrayScript : MonoBehaviour
{
    
    void Start()
    {
        int[] array = SetArray(100);
        
        ChoiseSort(array);
        //BubbleSort(array);
        WriteArray(array);

    }

    private int[] SetArray(int lenght)
    {
        int[]  arr = new int[lenght];
        Random rnd = new Random();
        for (int i = 0; i < lenght; i++)
        {
            arr[i] = rnd.Next(-100,101);
        }
        return arr;
        
    }

    private void WriteArray(int[] arr)
    {
        foreach (int a in arr)
        {
            Debug.Log(a);
        }
    }
    private void BubbleSort(int[] arr)
    {
        int temp = 0;
        for (int i = 0;i < arr.Length;i++)
        {
            for (int j = 0; j < arr.Length -i-1; j++)
            {
             if (arr[j] > arr[j+1])
                {
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }             
            }
        }
    }

    private void ChoiseSort(int[] arr)
    {
        int indx;
        for (int i = 0;i < arr.Length ; i++)
        {
            indx = i;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] < arr[indx])
                {
                    indx = j;
                }
            }
            if (arr[indx] == arr[i])            
                continue;            
            int temp = arr[i];
            arr[i] = arr[indx];
            arr[indx] = temp;
        }
    }
    
}
