#Query1
db.classwork.insertOne({
    "_id": 123,
    "Emp_ID": "10025AE336",
    "Personal_details": {
        "First_Name": "Abc",
        "Last_Name": "Def",
        "Date_Of_Birth": "1996-11-24"
    },
    "Contact": {
        "e-mail": "abcded@gmail.com",
        "phone": "9848022338"
    },
    "Address": {
        "city": "Hyderabad",
        "Area": "Madapur",}}
		
	#output
	{
  acknowledged: true,
  insertedId: 123
}
#Query2		
db.Class.insertMany({
    "id": "POST_ID",
    "title": "TITLE_OF_POST",
    "description": "POST_DESCRIPTION",
    "by": "POST_BY",
    "url": "URL_OF_POST",
    "tags": ["TAG1", "TAG2", "TAG3"],
    "likes": "TOTAL_LIKES",
    "comments": [
        {
            "user": "COMMENT_BY",
            "message": "TEXT",
            "dateCreated": "DATE_TIME",
            "like": "LIKES"
        },
        {
            "user": "COMMENT_BY",
            "message": "TEXT",
            "dateCreated": "DATE_TIME",
            "like": "LIKES"
        }
    ]
}
)

	#output
	{
  acknowledged: true,
  insertedId: POST_ID
}

#Query3
db.Class.insertMany([
   {
      "_id": ObjectId("0089"),
      "contact": 987654321,
      "dob": "11-24-1996",
      "name": "Ed Amy",
      "address": [
         {
            "building": "22 A, West Apt",
            "pincode": 34556,
            "city": "Cincinati",
            "state": "Ohio"
         },
         {
            "building": "369 A, My Home Apt",
            "pincode": 456789,
            "city": "Chicago",
            "state": "Illinois"
         }
      ]
   }
])
#output
	{
  acknowledged: true,
  insertedId: POST_ID
}
