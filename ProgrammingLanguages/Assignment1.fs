module Assignment1


let is_older first second =
    let isValidDate x =
        match x with
        | (year, month, day) when year > 0 && month  >= 1 && month <= 12 && day > 1 && day <= 365 -> true
        | _ -> false;

    if isValidDate first = false then raise (System.Exception("invalid date"))
    if isValidDate second = false then raise (System.Exception("invalid date"))
     
    if first >= second then true else false






