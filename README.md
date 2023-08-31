# TreeCollection Task

This repository contains a solution for the TreeCollection task, which involves modifying the `ExamResult` class, implementing the `Tree<T>` class, and ensuring that all unit tests pass successfully.

## Table of Contents
- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Modifications to ExamResult Class](#modifications-to-examresult-class)
- [Implementation of Tree<T> Class](#implementation-of-treet-class)
- [Running Unit Tests](#running-unit-tests)

## Introduction

The task involves working with a collection based on a binary tree structure. It includes modifying the `ExamResult` class for comparison based on specific criteria and implementing the `Tree<T>` class to store elements in a binary tree.

## Prerequisites

To work on this task, you will need:

- Visual Studio or an IDE of your choice that supports C# development.
- The TreeCollection solution.

## Modifications to ExamResult Class

The `ExamResult` class in the `TreeCollection.TestModels` project needs to be modified to implement the `IComparable` interface. The comparison logic should be based on the student's name. If the student's names are the same, the comparison should be based on the date of the exam. If both the student's name and exam date are the same, the comparison should be based on the ID entry.

## Implementation of Tree<T> Class

The `Tree<T>` class in the `TreeCollection` project needs to be implemented as a generalized collection that stores data as a binary tree. Key functionalities to implement include:

- Creating an initially empty tree with no elements.
- Allowing the specification of a traversal method (left-to-right or right-to-left) when creating a `Tree<T>` using a constructor with a boolean parameter `isReversedReading`. If `isReversedReading` is false, traverse the tree recursively from left to right; if true, traverse it from right to left.
- Implementing an `Add(T newElement)` method that adds a new element to the collection. New elements should be added to the appropriate branches of the tree based on their values.
- Throwing exceptions when trying to add duplicate values to the tree.
- Implementing the `IEnumerable<T>` interface in the `Tree<T>` class.

## Running Unit Tests

Ensure that all unit tests in the `TreeCollection.Tests` assembly pass successfully. The tests should cover various scenarios and edge cases for the `Tree<T>` class.
