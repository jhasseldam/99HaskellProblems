namespace Lists

module OneToTen =
    
    /// Problem 1: Find the last element of a list
    let rec lastElement lst = 
        match lst with
        | [] -> failwith "Empty list"
        | x::[] -> x
        | x::xs -> lastElement xs

    // Cheating
    let lastElement' lst = List.last lst

    /// Problem 2: Find the last but one element of a list
    let rec lastButOne lst = 
        match lst with
        | [] -> failwith "list does not containe two or more elements"
        | x::y::[] -> x
        | x::xs -> lastButOne xs
    
    /// Problem 3: Find the kth element of a list
    let elementAt k lst =
        let rec elementAtRec lst n = 
            match lst with
            | x::xs -> if n = k then x else elementAtRec xs (n+1)
            | [] -> failwith "Element out of range"
        elementAtRec lst 1 
    
    // Cheating
    let elementAt' k lst = List.item (k-1) lst

    /// Problem 4: Find the number of elements in a list
    let length lst =
        let rec lengthRec lst n = 
            match lst with
            | [] -> n
            | x::xs -> lengthRec xs (n+1)
        lengthRec lst 0
    
    // Cheating
    let length' lst = List.length lst

    /// Problem 5: Reverse a list
    let reverse lst = 
        let rec reverseRec inLst outLst =
            match inLst with
            | [] -> outLst
            | x::xs -> reverseRec xs (x::outLst) 
        reverseRec lst []
    
    // Cheating
    let reverse' lst = List.rev lst

    /// Problem 6: Is list a palindrome
    let isPalindrome lst = lst = (reverse lst)

    // The hard way
    let isPalindrome' lst =
        let revLst = reverse lst
        let rec isPalindrome' lst revLst =
            match (lst, revLst) with
            | (x::xs), (y::ys) -> if x = y then isPalindrome' xs ys else false
            | [], [] -> true
            | [], _::_ -> false // Will never happen but to satisfy compiler warning  
            | _::_, [] -> false // Will never happen but to satisfy compiler warning
        isPalindrome' lst revLst


        
    