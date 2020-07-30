# CrossThread
Update UI from different thread with delegate, support how to Cancel Thread when running long operation. 

# Delegate
Pass delegte with online method so no need to as beloew code:

 model.executeAsync(this.txtStatus.Text, delegate (object p)
            {
                string s = (string)p;
                uodateStatus(s);
            });
